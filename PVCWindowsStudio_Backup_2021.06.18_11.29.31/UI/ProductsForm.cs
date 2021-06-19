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
        private ProductBLL productBll;
        public ProductsForm()
        {
            product = new Products();
            productBll = new ProductBLL();
            InitializeComponent();
        }

        private void InitiateData()
        {
            var list = productBll.GetAll();
            productGridView.DataSource = list;
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

                productBll.Insert(product);
                InitiateData();
                Clear();
                this.radValidationProvider1.ClearErrorStatus();
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

        private void MasterTemplate_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            product = (Products)productGridView.Rows[rowindex].DataBoundItem;
            if (product != null)
            {
                lblID.Text = product.ProductID.ToString();
                txtName.Text = product.Name;
                txtDescription.Text = product.Other;
                if (product.Picture?.Length>0)
                    productPictureBox.Image = ConvertToImage(product.Picture);
                else
                    productPictureBox.Image = null;

            }
        }
        private Image ConvertToImage(byte[] array)
        {
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(array));
            return x;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

                productBll.Update(product);
                InitiateData();
                Clear();
                this.radValidationProvider1.ClearErrorStatus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productBll.Delete(int.Parse(lblID.Text));
                    InitiateData();
                    Clear();
                }

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            productPictureBox.Image = null;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
