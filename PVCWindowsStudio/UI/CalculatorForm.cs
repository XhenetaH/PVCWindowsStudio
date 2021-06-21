using PVCWindowsStudio.BLL;
using PVCWindowsStudio.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;


namespace PVCWindowsStudio.UI
{
    public partial class CalculatorForm : Telerik.WinControls.UI.RadForm
    {
        private Clients client;
        private ClientBLL clientBll;
        private OrderDetails details;
        private OrderDetailsBLL detailsBll;
        private Orders order;
        private OrderBLL orderBll;
        private ProductBLL productBll;
        private ProfileBLL profileBll;
        private BlindBLL blindBll;
        private WindowPaneBLL windowpaneBll;
       
        public CalculatorForm()
        {
            order = new Orders();
            orderBll = new OrderBLL();
            client = new Clients();
            clientBll = new ClientBLL();
            details = new OrderDetails();
            detailsBll = new OrderDetailsBLL();
            productBll = new ProductBLL();           
            profileBll = new ProfileBLL();
            blindBll = new BlindBLL();
            windowpaneBll = new WindowPaneBLL();
            InitializeComponent();
        }

        private decimal CalcPrice(int productId,int profileId,int blindId,int paneId)
        {
            var formulaList = detailsBll.GetPrice(profileId,productId);

            for(int i=0; i< formulaList.Count;i++)
            {
                if(formulaList[i].Formula.Contains("Price"))
                {
                    formulaList[i].Formula = formulaList[i].Formula.Replace("Price", formulaList[i].Price);
                }
                if(formulaList[i].Formula.Contains("Width"))
                {
                    formulaList[i].Formula = formulaList[i].Formula.Replace("Width", txtWidth.Text);
                }
                if (formulaList[i].Formula.Contains("Height"))
                {
                    formulaList[i].Formula = formulaList[i].Formula.Replace("Height", txtHeight.Text);
                }
            }
            string total = "";

            for (int i = 0; i < formulaList.Count; i++)
            {
                total = total + "+" + formulaList[i].Formula;
            }

            decimal price = Convert.ToDecimal(new DataTable().Compute(total, null));

            if(blindId > -1)
            {
                var pr = blindBll.GetPrice(blindId);
                price += pr;
            }
            if(paneId>-1)
            {
                price += windowpaneBll.GetPrice(paneId);
            }
            return price;

        }



        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            productMultiComboBox.DataSource = productBll.GetExistProd();
            productMultiComboBox.SelectedIndex = -1;
            productMultiComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            productMultiComboBox.EditorControl.TableElement.RowHeight = 110;
            productMultiComboBox.Text = "Choose a product";

            clientradMultiColumnComboBox1.DataSource = clientBll.GetName();
            clientradMultiColumnComboBox1.SelectedIndex = -1;
            clientradMultiColumnComboBox1.AutoCompleteMode = AutoCompleteMode.Append;        
            clientradMultiColumnComboBox1.Text = "Choose a client";

            ddlProfile.DataSource = profileBll.GetExistProfile();
            ddlProfile.DisplayMember = "NameProf";
            ddlProfile.ValueMember = "ProfileID";
            ddlProfile.SelectedText = "Choose a profile";

            ddlBlinds.DataSource = blindBll.GetAll();
            ddlBlinds.DisplayMember = "Name";
            ddlBlinds.ValueMember = "BlindID";
            ddlBlinds.SelectedText = "Choose a blind";

            ddlWindowPane.DataSource = windowpaneBll.GetAll();
            ddlWindowPane.DisplayMember = "Name";
            ddlWindowPane.ValueMember = "WindowPaneID";
            ddlWindowPane.SelectedText = "Choose a window pane";
            discountCmb.SelectedIndex = 1;
        }

        private void productsradGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {

        }


        private void productsradGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = productMultiComboBox.EditorControl.CurrentCell.RowIndex;
            details.Product = (Products)productMultiComboBox.EditorControl.Rows[rowindex].DataBoundItem;

            lblProductID.Text = details.Product.ProductID.ToString();
            if (details.Product.Picture?.Length >0)
                radPictureBox1.Image = ConvertToImage(details.Product.Picture);
            else
                radPictureBox1.Image = null;
        }

        private Image ConvertToImage(byte[] array)
        {
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(array));
            return x;
        }

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            int clientID = 0;
            if (calculatorGridView.RowCount != 0)
            {
                if (String.IsNullOrEmpty(lblClientID.Text))
                {
                    if (String.IsNullOrEmpty(txtName.Text))
                        radValidationProvider1.Validate(txtName);
                    else if (String.IsNullOrEmpty(txtLastName.Text))
                        radValidationProvider1.Validate(txtLastName);
                    else
                    {
                        radValidationProvider1.ClearErrorStatus();
                        
                        client.Name = txtName.Text;
                        client.LastName = txtLastName.Text;
                        client.PhoneNumber = txtPhoneNr.Text;
                        client.Address = txtAddress.Text;
                        client.Email = txtEmail.Text;
                        client.InsertBy = 1;

                        clientBll.Insert(client);
                        clientID = clientBll.GetID();
                    }
                    
                }
                else
                {
                    clientID = int.Parse(lblClientID.Text);
                }
                if (clientID != 0)
                {
                    order.ClientID = clientID;
                    order.Date = DateTime.Now;
                    order.Comment = "";
                    if (String.IsNullOrEmpty(txtDiscount.Text))
                        order.Discount = 0;
                    else
                        order.Discount = Convert.ToDecimal(txtDiscount.Text);
                    order.DiscountType = discountCmb.Text;
                    order.TotalPrice = Convert.ToDecimal(txtTotal.Text);
                    order.InsertBy = 1;
                    if (orderBll.Insert(order))
                        MessageBox.Show("Order inserted successfully!");

                    for (int i = 0; i < calculatorGridView.RowCount; i++)
                    {
                        details.OrderID = orderBll.GetID();
                        details.ProductID = int.Parse(calculatorGridView.Rows[i].Cells["ProductID"].Value.ToString());
                        details.ProfileID = int.Parse(lblProfileID.Text);
                        details.BlindID = int.Parse(calculatorGridView.Rows[i].Cells["BlindsID"].Value.ToString());
                        details.WindowPaneID = int.Parse(lblWindowPaneID.Text);
                        details.Quantity = int.Parse(calculatorGridView.Rows[i].Cells["Quantity"].Value.ToString());
                        details.Width = Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Width"].Value);
                        details.Height = Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Height"].Value);
                        details.Price = Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Price"].Value);
                        details.Total = Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Total"].Value);
                        details.InsertBy = 1;

                        detailsBll.Insert(details);
                    }
                }

            }
            else
            {
                MessageBox.Show("Your order is empty!");
            }       
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (radPictureBox1.Image != null)
            {

                if (!String.IsNullOrEmpty(txtHeight.Text))
                {

                    if (!String.IsNullOrEmpty(txtWidth.Text))
                    {

                        if (!String.IsNullOrEmpty(txtQuantity.Text))
                        {
                            if (ddlProfile.SelectedValue != null)
                            {
                                if (ddlBlinds.SelectedValue != null)
                                {
                                    if (ddlWindowPane.SelectedValue != null)
                                    {

                                            int rowindex = productMultiComboBox.EditorControl.CurrentCell.RowIndex;
                                            details.ProductID = int.Parse(lblProductID.Text);
                                            details.Product = new Products();
                                            details.Product.Name = productMultiComboBox.EditorControl.Rows[rowindex].Cells["Name"].Value.ToString();
                                            details.Width = Convert.ToDecimal(txtWidth.Text);
                                            details.Height = Convert.ToDecimal(txtHeight.Text);
                                            details.Quantity = int.Parse(txtQuantity.Text);
                                            details.ProfileID = int.Parse(lblProfileID.Text);
                                            details.BlindID = int.Parse(lblBlindID.Text);
                                            details.Blind = new Blinds();
                                            details.Blind.Name = ddlBlinds.Text;
                                            details.WindowPaneID = int.Parse(lblWindowPaneID.Text);
                                            radValidationProvider1.ClearErrorStatus();
                                            details.Price = CalcPrice(details.ProductID, details.ProfileID, details.BlindID, details.WindowPaneID);
                                            details.Total = details.Price * details.Quantity;
                                            calculatorGridView.Rows.Add(details.ProductID, details.Product.Name, details.Width, details.Height, details.Quantity, details.BlindID, details.Blind.Name, details.Price, details.Total);
                                            ClearProdInfo();
                                        
                                    }
                                    else
                                        radValidationProvider1.Validate(ddlWindowPane);
                                }
                                else
                                    radValidationProvider1.Validate(ddlBlinds);
                            }
                            else
                                radValidationProvider1.Validate(ddlProfile);
                        }
                        else
                            radValidationProvider1.Validate(txtQuantity);
                    }
                    else
                        radValidationProvider1.Validate(txtWidth);
                }
                else
                    radValidationProvider1.Validate(txtHeight);
            }
            else
                MessageBox.Show("Product canot be empty");
        }

        private void radMultiColumnComboBox1_EditorControl_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = productMultiComboBox.EditorControl.CurrentCell.RowIndex;
            details.Product = (Products)productMultiComboBox.EditorControl.Rows[rowindex].DataBoundItem;

            lblProductID.Text = details.Product.ProductID.ToString();
            if (details.Product.Picture?.Length > 0)
                radPictureBox1.Image = ConvertToImage(details.Product.Picture);
            else
                radPictureBox1.Image = null;
        }

        private void clientradMultiColumnComboBox1_EditorControl_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindx = clientradMultiColumnComboBox1.EditorControl.CurrentCell.RowIndex;
            client = (Clients)clientradMultiColumnComboBox1.EditorControl.Rows[rowindx].DataBoundItem;
            lblClientID.Text = client.ClientID.ToString();
            txtName.Text = client.Name;
            txtLastName.Text = client.LastName;
            txtPhoneNr.Text = client.PhoneNumber;
            txtEmail.Text = client.Email;
            txtAddress.Text = client.Address;
        }



        private void TotalPriceCalc()
        {

            if (String.IsNullOrEmpty(txtDiscount.Text))
                txtTotal.Text = Convert.ToString(Math.Round(Total() - 0));
            else
            {
                if (discountCmb.SelectedIndex == 0)
                    txtTotal.Text = Convert.ToString(Math.Round(Total() - Discount()));
                if (discountCmb.SelectedIndex == 1)
                    txtTotal.Text = Convert.ToString(Math.Round(Total() - Convert.ToDecimal(txtDiscount.Text)));
            }

        }

        private decimal Total()
        {
            decimal total = 0;
            for (int i = 0; i < calculatorGridView.Rows.Count; i++)
            {
                total += Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Total"].Value);
            }
            return Math.Round(total);

        }

        private decimal Discount()
        {
            decimal discount = Convert.ToDecimal(txtDiscount.Text);

            discount = (discount / 100) * Total();
            return discount;
        }

        private void calculatorGridView_RowsChanged(object sender, Telerik.WinControls.UI.GridViewCollectionChangedEventArgs e)
        {
            TotalPriceCalc();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            TotalPriceCalc();
        }

        private void discountCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            TotalPriceCalc();
        }

        private void save_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClearClient_Click(object sender, EventArgs e)
        {
            clientradMultiColumnComboBox1.SelectedIndex = -1;
            clientradMultiColumnComboBox1.Text = "Choose a client";

            lblClientID.Text = "";
            txtName.Text = "";
            txtLastName.Text = "";
            txtPhoneNr.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private void btnClearInfo_Click(object sender, EventArgs e)
        {
            radPictureBox1.Image = null;
            productMultiComboBox.SelectedIndex=-1;
            productMultiComboBox.Text = "Choose a product";
            txtHeight.Text = "";
            txtWidth.Text = "";
            txtQuantity.Text = "";
            ddlProfile.SelectedIndex = -1;
            ddlProfile.Text = "Choose a product";
            ddlBlinds.SelectedIndex = -1;
            ddlBlinds.Text = "Choose a blind";
            ddlWindowPane.SelectedIndex = -1;
            ddlWindowPane.Text = "Choose a window pane";
        }

        private void ClearProdInfo()
        {
            txtWidth.Text = "";
            txtHeight.Text = "";
            txtQuantity.Text = "";
            ddlBlinds.SelectedIndex = -1;
            ddlBlinds.Text = "Choose a blind";
            lblBlindID.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            while (calculatorGridView.RowCount != 0)
            {
                for (int i = 0; i < calculatorGridView.RowCount; i++)
                {
                    calculatorGridView.Rows.RemoveAt(i);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void ddlProfile_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddlProfile.SelectedIndex > -1)
            {
                lblProfileID.Text = ddlProfile.SelectedValue.ToString();
            }
        }

        private void ddlWindowPane_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddlWindowPane.SelectedIndex > -1)
            {
                lblWindowPaneID.Text = ddlWindowPane.SelectedValue.ToString();
            }
        }

        private void ddlBlinds_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (ddlBlinds.SelectedIndex > -1)
            {
                lblBlindID.Text = ddlBlinds.SelectedValue.ToString();
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            

        }
    }
}
