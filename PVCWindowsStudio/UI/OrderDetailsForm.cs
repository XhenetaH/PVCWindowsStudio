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
    public partial class OrderDetailsForm : Telerik.WinControls.UI.RadForm
    {
        private readonly OrderBLL ordersBLL;
        private Orders order;
        private readonly BlindBLL blindBll;
        private readonly OrderDetailsBLL detailsBLL;
        private OrderDetails details;
        private readonly ProductBLL productBll;
        private readonly ProfileBLL profileBll;
        private readonly WindowPaneBLL windowpaneBll;
        public OrderDetailsForm()
        {
            productBll = new ProductBLL();
            profileBll = new ProfileBLL();
            windowpaneBll = new WindowPaneBLL();
            blindBll = new BlindBLL();
            detailsBLL = new OrderDetailsBLL();
            ordersBLL = new OrderBLL();
            order = new Orders();
            details = new OrderDetails();
            InitializeComponent();
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            InitOrderData();

            productMultiColumnComboBox1.DataSource = productBll.GetExistProd();
            productMultiColumnComboBox1.SelectedIndex = -1;
            productMultiColumnComboBox1.AutoCompleteMode = AutoCompleteMode.Append;
            productMultiColumnComboBox1.EditorControl.TableElement.RowHeight = 110;
            productMultiColumnComboBox1.Text = "Choose a product";

            ddlBlinds.DataSource = blindBll.GetAll();
            ddlBlinds.DisplayMember = "Name";
            ddlBlinds.ValueMember = "BlindID";
            ddlBlinds.SelectedText = "Choose a blind";

            ddlProfile.DataSource = profileBll.GetExistProfile();
            ddlProfile.DisplayMember = "NameProf";
            ddlProfile.ValueMember = "ProfileID";
            ddlProfile.SelectedText = "Choose a profile";


            ddlWindowPane.DataSource = windowpaneBll.GetAll();
            ddlWindowPane.DisplayMember = "Name";
            ddlWindowPane.ValueMember = "WindowPaneID";
            ddlWindowPane.SelectedText = "Choose a window pane";

        }

        private void InitOrderData()
        {
            orderMultiComboBox.DataSource = ordersBLL.GetAll();
            orderMultiComboBox.SelectedIndex = -1;
            orderMultiComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            orderMultiComboBox.ValueMember = "OrderID";
            orderMultiComboBox.DisplayMember = "OrderID";
            orderMultiComboBox.Text = "Choose a order";
        }

        private void radMultiColumnComboBox1_EditorControl_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
                int id = int.Parse(orderMultiComboBox.EditorControl.Rows[rowindex].Cells["OrderID"].Value.ToString());
                lblOrderID.Text = id.ToString();
            }
        }

        private void productMultiColumnComboBox_EditorControl_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
                int id = int.Parse(productMultiColumnComboBox1.EditorControl.Rows[rowindex].Cells["ProductID"].Value.ToString());
                lblProductID.Text = id.ToString();
            }
        }

        private void lblOrderID_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblOrderID.Text))
                InitOrderDetailsData(int.Parse(lblOrderID.Text));
        }

        private void InitOrderDetailsData(int id)
        {
            orderDetailsradGridView.DataSource = detailsBLL.GetAll(id);
        }
        private void orderDetailsradGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
                details = (OrderDetails)orderDetailsradGridView.Rows[rowindex].DataBoundItem;
                if (details != null)
                {
                    lblID.Text = details.OrderDetailsID.ToString();
                    txtWidth.Text = details.Width.ToString();
                    txtHeight.Text = details.Height.ToString();
                    txtQuantity.Text = details.Quantity.ToString();
                    ddlBlinds.Text = details.Blind.Name;
                    ddlBlinds.SelectedValue = details.BlindID;
                    ddlProfile.Text = details.Profile.NameProf;
                    ddlProfile.SelectedValue = details.ProfileID;
                    ddlWindowPane.Text = details.WindowPane.Name;
                    ddlWindowPane.SelectedValue = details.WindowPaneID;
                    productMultiColumnComboBox1.Text = details.Product.Name;
                    lblProductID.Text = details.ProductID.ToString();
                    if (details.Product.Picture?.Length > 0)
                        radPictureBox1.Image = ConvertToImage(details.Product.Picture);
                    else
                        radPictureBox1.Image = null;

                }
            }
        }
        private Image ConvertToImage(byte[] array)
        {
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(array));
            return x;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (radPictureBox1.Image != null)
                {

                    if (String.IsNullOrEmpty(txtHeight.Text)&& String.IsNullOrEmpty(txtWidth.Text)&& String.IsNullOrEmpty(txtQuantity.Text))
                    {
                        radValidationProvider1.Validate(txtHeight);
                        radValidationProvider1.Validate(txtWidth);
                        radValidationProvider1.Validate(txtQuantity);
                    }
                    
                    //if (ddlProfile.SelectedValue == null)
                    //{
                    //    radValidationProvider1.Validate(ddlProfile);
                    //}
                    //if (ddlBlinds.SelectedValue == null)
                    //{
                    //    radValidationProvider1.Validate(ddlBlinds);
                    //}
                    //if (ddlWindowPane.SelectedValue == null)
                    //{
                    //    radValidationProvider1.Validate(ddlWindowPane);
                    //}
                    else
                    {
                        details.OrderDetailsID = int.Parse(lblID.Text);
                        details.Width = Convert.ToDecimal(txtWidth.Text);
                        details.Height = Convert.ToDecimal(txtHeight.Text);
                        details.Quantity = int.Parse(txtQuantity.Text);
                        details.BlindID = int.Parse(ddlBlinds.SelectedValue.ToString());
                        details.ProfileID = int.Parse(ddlProfile.SelectedValue.ToString());
                        details.ProductID = int.Parse(lblProductID.Text);
                        details.WindowPaneID = int.Parse(ddlWindowPane.SelectedValue.ToString());
                        details.Price = Session.Methods.CalcPrice(details.ProductID, txtWidth.Text, txtHeight.Text, details.ProfileID, details.BlindID, blindBll.GetPrice(details.BlindID), windowpaneBll.GetPrice(details.WindowPaneID), details.WindowPaneID, detailsBLL.GetPrice(details.ProfileID, details.ProductID));
                        details.Total = details.Price * details.Quantity;
                        details.LUB = 1;

                        if (detailsBLL.Update(details))
                        {
                            MessageBox.Show("Order details updated successfully!");
                            InitOrderDetailsData(details.OrderID);
                            Clear();
                        }
                        else
                            MessageBox.Show("Something went wrong!");
                    }
                }
                else
                    MessageBox.Show("Product canot be empty");
            }
            else
                MessageBox.Show("Please select an item from your order!");
        }

        private void Clear()
        {
            productMultiColumnComboBox1.Text = "Choose a product";
            productMultiColumnComboBox1.SelectedIndex = -1;
            lblProductID.Text = "";
            txtHeight.Text = "";
            txtWidth.Text = "";
            txtQuantity.Text = "";
            ddlBlinds.Text = "Choose a blind";
            ddlBlinds.SelectedIndex = -1;
            ddlWindowPane.Text = "Choose a window pane";
            ddlWindowPane.SelectedIndex = -1;
            ddlProfile.Text = "Choose a profile";
            ddlProfile.SelectedIndex = -1;
            lblID.Text = "";            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    detailsBLL.Delete(int.Parse(lblID.Text));
                    InitOrderDetailsData(details.OrderID);
                    if (orderDetailsradGridView.RowCount == 0)
                    {
                        if (ordersBLL.Delete(details.OrderID))
                        {
                            MessageBox.Show("Order item deleted successfully!");
                            InitOrderData();
                        }
                        else MessageBox.Show("Something went wrong!");
                    }
                    Clear();
                }
            }
            else MessageBox.Show("Please select an order item!");
        }
    }
}
