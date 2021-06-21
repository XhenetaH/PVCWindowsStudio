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
    public partial class ProductsForm : Telerik.WinControls.UI.RadForm
    {
        private Products product;
        private readonly ProductBLL productBll;
        public ProductsForm()
        {
            product = new Products();
            productBll = new ProductBLL();
            InitializeComponent();
        }

        private void InitiateData()
        {
            productGridView.DataSource = productBll.GetAll();
            this.productGridView.TableElement.RowHeight = 130;
        }
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (productPictureBox.Image == null)
                MessageBox.Show("Picture box can't be empty!");
            else if (String.IsNullOrEmpty(txtName.Text))
                this.radValidationProvider1.Validate(txtName);
            else
            {
                product.Name = txtName.Text;
                product.Other = txtDescription.Text;
                product.Picture = ConvertFormImage(productPictureBox.Image);
                product.InsertBy = 1;

                if (productBll.Insert(product))
                {
                    MessageBox.Show("Product inserted successfully!");
                    InitiateData();
                    Clear();
                    this.radValidationProvider1.ClearErrorStatus();
                }
                else MessageBox.Show("Something went wrong!");
            }
        }

        private byte[] ConvertFormImage(Image img)
        {
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            return arr;
        }
        private void Clear()
        {
            this.radValidationProvider1.ClearErrorStatus();
            lblID.Text = "";
            txtName.Text = "";
            txtDescription.Text = "";
            productPictureBox.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string filename;
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg|PNG|*.png", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                    productPictureBox.Image = Image.FromFile(filename);
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
                if (productPictureBox.Image == null)
                    MessageBox.Show("Picture box can't be empty!");
                else if (String.IsNullOrEmpty(txtName.Text))
                    this.radValidationProvider1.Validate(txtName);
                else
                {
                    product.Name = txtName.Text;
                    product.Other = txtDescription.Text;
                    product.Picture = ConvertFormImage(productPictureBox.Image);
                    product.LUB = 1;

                    if (productBll.Update(product))
                    {
                        MessageBox.Show("Product updated successfully!");
                        InitiateData();
                        Clear();
                        this.radValidationProvider1.ClearErrorStatus();
                    }
                    else MessageBox.Show("Something went wrong!");
                }
            }
            else MessageBox.Show("Please select an product!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (productBll.Delete(int.Parse(lblID.Text)))
                    {
                        MessageBox.Show("Product is deleted successfully!");
                        InitiateData();
                        Clear();
                    }
                    else MessageBox.Show("Something went wrong!");
                }
            }
            else MessageBox.Show("Please select an product!");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            productPictureBox.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void productGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
                product = (Products)productGridView.Rows[rowindex].DataBoundItem;

                if (product != null)
                {
                    lblID.Text = product.ProductID.ToString();
                    txtName.Text = product.Name;
                    txtDescription.Text = product.Other;
                    if (product.Picture?.Length > 0)
                        productPictureBox.Image = ConvertToImage(product.Picture);
                    else
                        productPictureBox.Image = null;

                }
            }
        }
    }
}
