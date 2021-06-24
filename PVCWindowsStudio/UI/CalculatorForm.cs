using PVCWindowsStudio.BLL;
using PVCWindowsStudio.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Telerik.Documents.SpreadsheetStreaming;
using Telerik.WinControls;
using Telerik.WinControls.Export;
using Telerik.WinControls.UI;

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
        private HandiWorkBLL workBll;
        public bool validating = false;
        public CalculatorForm()
        {
            workBll = new HandiWorkBLL();
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

        private decimal CalcPrice(int productId,int profileId,int blindId,int paneId,decimal width,decimal height)
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
                    formulaList[i].Formula = formulaList[i].Formula.Replace("Width", width.ToString());
                }
                if (formulaList[i].Formula.Contains("Height"))
                {
                    formulaList[i].Formula = formulaList[i].Formula.Replace("Height", height.ToString());
                }
            }
            string total = "";

            for (int i = 0; i < formulaList.Count; i++)
            {
                total = total + "+" + formulaList[i].Formula;
            }

            decimal price = Convert.ToDecimal(new DataTable().Compute(total, null));

            var paneprice = GetWindowPanePrice(paneId,width,height);
            var blindprice = GetBlindPrice(blindId,width,height);
            var handiworkprice = HandiWorkPrice(width, height);         
            return Math.Round(price + paneprice + handiworkprice + blindprice);

        }

        private decimal GetWindowPanePrice(int id,decimal width,decimal height)
        {
            var pr = windowpaneBll.GetPrice(id);
            if (pr != -1)
                return (height / 100) * (width / 100) * pr;
            else return 0;
                    
        }
        private decimal GetBlindPrice(int id, decimal width, decimal height)
        {
            var pr = blindBll.GetPrice(id);
            if (pr != -1)
                return (height / 100) * (width / 100) * pr;
            else return 0;

        }

        private decimal HandiWorkPrice(decimal width,decimal height)
        {
            var pr = workBll.GetPrice(width,height);
            if (pr != -1)
                return pr;
            else return 0;
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
           
            clientradMultiColumnComboBox1.DataSource = clientBll.GetName();
            clientradMultiColumnComboBox1.SelectedIndex = -1;
            clientradMultiColumnComboBox1.AutoCompleteMode = AutoCompleteMode.Append;
            clientradMultiColumnComboBox1.Text = "Choose a client";


            GridViewComboBoxColumn col = this.calculatorGridView.Columns["Blind"] as GridViewComboBoxColumn;
            col.DataSource = blindBll.GetAll();
            col.DisplayMember = "Name";
            col.ValueMember = "BlindID";

            GridViewMultiComboBoxColumn multi = this.calculatorGridView.Columns["Product"] as GridViewMultiComboBoxColumn;
            multi.DataSource = productBll.GetExistProd();
            multi.DisplayMember = "Name";
            multi.ValueMember = "ProductID";



            ddlProfile.DataSource = profileBll.GetExistProfile();
            ddlProfile.DisplayMember = "NameProf";
            ddlProfile.ValueMember = "ProfileID";

            ddlWindowPane.DataSource = windowpaneBll.GetAll();
            ddlWindowPane.DisplayMember = "Name";
            ddlWindowPane.ValueMember = "WindowPaneID";

            discountCmb.SelectedIndex = 1;

            RadMessageBox.SetThemeName("MaterialBlueGrey");
        }


        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            int clientID = 0;
            if (calculatorGridView.RowCount != 0)
            {
                if (String.IsNullOrEmpty(lblClientID.Text))
                {
                    if(ValidationMethod())
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
                    {
                        
                        RadMessageBox.Show("Order inserted successfully!");
                        
                    }
                    for (int i = 0; i < calculatorGridView.RowCount; i++)
                    {
                        details.OrderID = orderBll.GetID();
                        details.ProductID = int.Parse(calculatorGridView.Rows[i].Cells["Product"].Value.ToString());
                        details.ProfileID = int.Parse(ddlProfile.SelectedValue.ToString());
                        details.BlindID = int.Parse(calculatorGridView.Rows[i].Cells["Blind"].Value.ToString());
                        details.WindowPaneID = int.Parse(ddlWindowPane.SelectedValue.ToString());
                        details.Quantity = int.Parse(calculatorGridView.Rows[i].Cells["Quantity"].Value.ToString());
                        details.Width = int.Parse(calculatorGridView.Rows[i].Cells["Width"].Value.ToString());
                        details.Height = int.Parse(calculatorGridView.Rows[i].Cells["Height"].Value.ToString());
                        details.Price = Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Price"].Value);
                        details.Total = Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Total"].Value);
                        details.InsertBy = 1;

                        detailsBll.Insert(details);
                    }
                }

            }
            else
            {
                
                RadMessageBox.Show("Your order is empty!");
                
            }       
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
            if (e.Action == Telerik.WinControls.Data.NotifyCollectionChangedAction.Add)
            {                
                var newRow = e.NewItems[0] as GridViewDataRowInfo;
                newRow.Cells["Price"].Value = CalcPrice(int.Parse(newRow.Cells["Product"].Value.ToString()), int.Parse(ddlProfile.SelectedValue.ToString()), int.Parse(newRow.Cells["Blind"].Value.ToString()), int.Parse(ddlWindowPane.SelectedValue.ToString()), Convert.ToDecimal(newRow.Cells["Width"].Value.ToString()), Convert.ToDecimal(newRow.Cells["Height"].Value.ToString()));
                newRow.Cells["Total"].Value = Convert.ToDecimal(newRow.Cells["Price"].Value) * int.Parse(newRow.Cells["Quantity"].Value.ToString());
            }
            
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

            ddlProfile.SelectedIndex = -1;
            ddlProfile.Text = "Choose a profile";
            ddlWindowPane.SelectedIndex = -1;
            ddlWindowPane.Text = "Choose a window pane";
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

        bool isColmnAdded;
        private void calculatorGridView_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            if (this.calculatorGridView.CurrentColumn is GridViewMultiComboBoxColumn)
            {
                if (!isColmnAdded)
                {
                    isColmnAdded = true;
                    RadMultiColumnComboBoxElement editor = (RadMultiColumnComboBoxElement)this.calculatorGridView.ActiveEditor;
                    editor.EditorControl.MasterTemplate.AutoGenerateColumns = false;
                    editor.EditorControl.AllowSearchRow = true;
                    editor.EditorControl.Columns.Add(new GridViewTextBoxColumn("ProductID"));
                    editor.EditorControl.Columns.Add(new GridViewImageColumn("Picture"));
                    editor.EditorControl.Columns.Add(new GridViewTextBoxColumn("Name"));
                    editor.EditorControl.Columns[0].IsVisible = false;
                    editor.EditorControl.Columns[1].ImageLayout = ImageLayout.Zoom;
                    editor.EditorControl.Columns[1].Width = 130;
                    editor.EditorControl.Columns[2].Width = 100;
                    editor.EditorControl.TableElement.RowHeight = 110;
                    editor.EditorControl.Width = 200;
                    
                    
                }
            }

        }

        private void calculatorGridView_CellValidating(object sender, CellValidatingEventArgs e)
        {
            var currentRow = calculatorGridView.CurrentRow;
            if (!e.ColumnIndex.Equals(-1) && !e.RowIndex.Equals(-1))
            {
                if (e.Column.Name == "Product")
                {
                    if (e.Value == null)
                    {                        
                        e.Cancel = true;
                        RadMessageBox.Show($"{e.Column.Name} can't be empty!");
                    }
                    else
                    {
                        currentRow.Cells["Price"].Value = CalcPrice(int.Parse(e.Value.ToString()), int.Parse(ddlProfile.SelectedValue.ToString()), int.Parse(currentRow.Cells["Blind"].Value.ToString()), int.Parse(ddlWindowPane.SelectedValue.ToString()), Convert.ToDecimal(currentRow.Cells["Width"].Value.ToString()), Convert.ToDecimal(currentRow.Cells["Height"].Value.ToString()));
                        currentRow.Cells["Total"].Value = Convert.ToDecimal(currentRow.Cells["Price"].Value) * int.Parse(currentRow.Cells["Quantity"].Value.ToString());

                    }
                }
                if(e.Column.Name == "Blind")
                {
                    if(e.Value == null)
                    {
                        e.Cancel = true;
                        RadMessageBox.Show($"{e.Column.Name} can't be empty!");
                    }
                    else
                    {
                        currentRow.Cells["Price"].Value = CalcPrice(int.Parse(currentRow.Cells["Product"].Value.ToString()), int.Parse(ddlProfile.SelectedValue.ToString()), int.Parse(e.Value.ToString()), int.Parse(ddlWindowPane.SelectedValue.ToString()), Convert.ToDecimal(currentRow.Cells["Width"].Value.ToString()), Convert.ToDecimal(currentRow.Cells["Height"].Value.ToString()));
                        currentRow.Cells["Total"].Value = Convert.ToDecimal(currentRow.Cells["Price"].Value) * int.Parse(currentRow.Cells["Quantity"].Value.ToString());

                    }
                }
                if(e.Column.Name == "Width")
                {
                    if (e.Value != null)
                    {
                        int nr;
                        if (!int.TryParse(e.Value.ToString(), out nr))
                        {
                            e.Cancel = true;
                            RadMessageBox.Show($"{e.Column.Name} must be a number!");
                        }
                        else
                        {
                            currentRow.Cells["Price"].Value = CalcPrice(int.Parse(currentRow.Cells["Product"].Value.ToString()), int.Parse(ddlProfile.SelectedValue.ToString()), int.Parse(currentRow.Cells["Blind"].Value.ToString()), int.Parse(ddlWindowPane.SelectedValue.ToString()), Convert.ToDecimal(e.Value.ToString()), Convert.ToDecimal(currentRow.Cells["Height"].Value.ToString()));
                            currentRow.Cells["Total"].Value = Convert.ToDecimal(currentRow.Cells["Price"].Value) * int.Parse(currentRow.Cells["Quantity"].Value.ToString());
                        }
                    }
                    else
                    {
                        e.Cancel = true;
                        RadMessageBox.Show($"{e.Column.Name} can't be empty!");
                    }

                }
                if (e.Column.Name == "Height")
                {
                    if (e.Value != null)
                    {
                        int nr;
                        if (!int.TryParse(e.Value.ToString(), out nr))
                        {
                            e.Cancel = true;
                            RadMessageBox.Show($"{e.Column.Name} must be a number!");
                        }
                        else
                        {
                            currentRow.Cells["Price"].Value = CalcPrice(int.Parse(currentRow.Cells["Product"].Value.ToString()), int.Parse(ddlProfile.SelectedValue.ToString()), int.Parse(currentRow.Cells["Blind"].Value.ToString()), int.Parse(ddlWindowPane.SelectedValue.ToString()), Convert.ToDecimal(currentRow.Cells["Width"].Value.ToString()), Convert.ToDecimal(e.Value.ToString()));
                            currentRow.Cells["Total"].Value = Convert.ToDecimal(currentRow.Cells["Price"].Value) * int.Parse(currentRow.Cells["Quantity"].Value.ToString());

                        }
                    }
                    else
                    {
                        e.Cancel = true;
                        RadMessageBox.Show($"{e.Column.Name} can't be empty!");
                    }
                }
                if (e.Column.Name == "Quantity")
                {
                    if (e.Value != null)
                    {
                        int nr;
                        if (!int.TryParse(e.Value.ToString(), out nr))
                        {
                            e.Cancel = true;
                            RadMessageBox.Show($"{e.Column.Name} must be a number!");
                        }
                        else
                        {
                            currentRow.Cells["Total"].Value = Convert.ToDecimal(currentRow.Cells["Price"].Value) * int.Parse(e.Value.ToString());

                        }
                    }
                    else
                    {
                        e.Cancel = true;         
                        RadMessageBox.Show($"{e.Column.Name} can't be empty!");
                    }

                }                
            }
        }

        private void calculatorGridView_UserAddingRow(object sender, GridViewRowCancelEventArgs e)
        {
            var currentcol = calculatorGridView.CurrentColumn;
            if (e.Rows[0].Cells["Product"].Value == null)
            {
                RadMessageBox.Show("Product can't be empty!");
                e.Cancel = true;
            }
            if (e.Rows[0].Cells["Blind"].Value == null)
            {
                RadMessageBox.Show("Blind can't be empty!");
                e.Cancel = true;
            }
            if (e.Rows[0].Cells["Width"].Value != null)
            {
                int nr;
                if (!int.TryParse(e.Rows[0].Cells["Width"].Value.ToString(), out nr))
                {
                    RadMessageBox.Show("Width must be a number!");
                    e.Cancel = true;
                }
                               
            }
            if (e.Rows[0].Cells["Width"].Value == null)
            {
                RadMessageBox.Show("Width can't be empty!");
                e.Cancel = true;
            }
            if (e.Rows[0].Cells["Height"].Value != null)
            {
                int nr;
                if (!int.TryParse(e.Rows[0].Cells["Height"].Value.ToString(), out nr))
                {
                    RadMessageBox.Show("Height must be a number!");
                    e.Cancel = true;
                }

            }
            if (e.Rows[0].Cells["Height"].Value == null)
            {
                RadMessageBox.Show("Height can't be empty!");
                e.Cancel = true;
            }
            if (e.Rows[0].Cells["Quantity"].Value != null)
            {
                int nr;
                if (!int.TryParse(e.Rows[0].Cells["Quantity"].Value.ToString(), out nr))
                {
                    RadMessageBox.Show("Quantity must be a number!");
                    e.Cancel = true;
                }

            }
            if (e.Rows[0].Cells["Quantity"].Value == null)
            {
                RadMessageBox.Show("Quantity can't be empty!");
                e.Cancel = true;
            }

        }



        private void ddlProfile_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < calculatorGridView.RowCount; i++)
            {
                calculatorGridView.Rows[i].Cells["Price"].Value = CalcPrice(int.Parse(calculatorGridView.Rows[i].Cells["Product"].Value.ToString()), int.Parse(ddlProfile.SelectedValue.ToString()), int.Parse(calculatorGridView.Rows[i].Cells["Blind"].Value.ToString()), int.Parse(ddlWindowPane.SelectedValue.ToString()), Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Width"].Value.ToString()), Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Height"].Value.ToString()));
                calculatorGridView.Rows[i].Cells["Total"].Value = Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Price"].Value) * int.Parse(calculatorGridView.Rows[i].Cells["Quantity"].Value.ToString());
            }


        }

        private void ddlWindowPane_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            for (int i = 0; i < calculatorGridView.RowCount; i++)
            {
                calculatorGridView.Rows[i].Cells["Price"].Value = CalcPrice(int.Parse(calculatorGridView.Rows[i].Cells["Product"].Value.ToString()), int.Parse(ddlProfile.SelectedValue.ToString()), int.Parse(calculatorGridView.Rows[i].Cells["Blind"].Value.ToString()), int.Parse(ddlWindowPane.SelectedValue.ToString()), Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Width"].Value.ToString()), Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Height"].Value.ToString()));
                calculatorGridView.Rows[i].Cells["Total"].Value = Convert.ToDecimal(calculatorGridView.Rows[i].Cells["Price"].Value) * int.Parse(calculatorGridView.Rows[i].Cells["Quantity"].Value.ToString());

            }
        }
        private bool ValidationMethod()
        {
            bool valid = true;
            if (this.radValidationProvider1.ValidationMode == ValidationMode.Programmatically)
            {
                foreach (Control control in this.radPanel1.Controls)
                {
                    RadEditorControl editorControl = control as RadEditorControl;
                    if (editorControl != null)
                    {
                        this.radValidationProvider1.Validate(editorControl);
                        var mode = this.radValidationProvider1.AssociatedControls;
                        foreach (var i in mode)
                        {
                            if (string.IsNullOrEmpty(i.AccessibilityObject.Value))
                                valid = false;
                        }
                    }
                }
            }
            return valid;
        }

        private void radPanel1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (calculatorGridView.RowCount>0)
            {

                string exportFile = string.Empty;
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    if (sfd.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    exportFile = sfd.FileName + ".xlsx";
                }
                if (!string.IsNullOrEmpty(exportFile))
                {
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        Telerik.WinControls.Export.GridViewSpreadExport exporter = new Telerik.WinControls.Export.GridViewSpreadExport(this.calculatorGridView);
                        Telerik.WinControls.Export.SpreadExportRenderer renderer = new Telerik.WinControls.Export.SpreadExportRenderer();
                        exporter.RunExport(ms, renderer);

                        using (System.IO.FileStream fileStream = new System.IO.FileStream(exportFile, FileMode.Create, FileAccess.Write))
                        {
                            ms.WriteTo(fileStream);
                            if (File.Exists(fileStream.Name)) RadMessageBox.Show("Order details exported to excel!");
                        }
                    }
                }
                else RadMessageBox.Show("Something went wrong!");
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

            if (calculatorGridView.RowCount > 0)
            {

                string exportFile = string.Empty;
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    if (sfd.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    exportFile = sfd.FileName + ".pdf";
                }
                if (!string.IsNullOrEmpty(exportFile))
                {
                    using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
                    {
                        Telerik.WinControls.Export.GridViewPdfExport exporter = new Telerik.WinControls.Export.GridViewPdfExport(this.calculatorGridView);
                        Telerik.WinControls.Export.PdfExportRenderer renderer = new Telerik.WinControls.Export.PdfExportRenderer();
                        exporter.RunExport(ms, renderer);

                        using (System.IO.FileStream fileStream = new System.IO.FileStream(exportFile, FileMode.Create, FileAccess.Write))
                        {
                            ms.WriteTo(fileStream);
                            if (File.Exists(fileStream.Name)) RadMessageBox.Show("Order details exported to pdf!");

                        }
                    }
                }
                else RadMessageBox.Show("Something went wrong!");
            }

        }
    }
}
