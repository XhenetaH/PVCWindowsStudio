using PVCWindowsStudio.BLL;
using PVCWindowsStudio.BLL.FormModels;
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
    public partial class ProductItemsForm : Telerik.WinControls.UI.RadForm
    {
        private ProductItemsModel productModel;
        public ProductItemsForm()
        {
            productModel = new ProductItemsModel()
            {
                Product = new Products(),
                ProductItems = new ProductItems(),
                MaterialBll = new MaterialBLL(),
                FormulaBll = new FormulaBLL(),
                ProductBLL = new ProductBLL(),
                ProductItemsBll = new ProductItemsBLL()
            };
            InitializeComponent();
        }

        private void InitiateProduct()
        {
            var productList = productModel.ProductBLL.GetAll();
            productsradGridView.DataSource = productList;
            this.productsradGridView.TableElement.RowHeight = 150;

            ddlMaterial.DataSource = productModel.MaterialBll.GetAll();
            ddlMaterial.DisplayMember = "Name";
            ddlMaterial.ValueMember = "MaterialID";

            ddlFormula.DataSource = productModel.FormulaBll.GetAll();
            ddlFormula.DisplayMember = "FormulaType";
            ddlFormula.ValueMember = "FormulaID";


        }
        private void ProductItemsForm_Load(object sender, EventArgs e)
        {
            InitiateProduct();
            InitiateProductItems();
        }

        private void productsradGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            productModel.Product = (Products)productsradGridView.Rows[rowindex].DataBoundItem;
            if (productModel.Product != null)
            {
                lblproductID.Text = productModel.Product.ProductID.ToString();
                if (productModel.Product.Picture?.Length > 0)
                    productPictureBox.Image = ConvertToImage(productModel.Product.Picture);
                else
                    productPictureBox.Image = null;

            }
        }

        private Image ConvertToImage(byte[] array)
        {
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(array));
            return x;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (productPictureBox.Image == null)
                MessageBox.Show("Picture box can't be empty!");
            else
            {
                productModel.ProductItems.ProductID = int.Parse(lblproductID.Text);
                productModel.ProductItems.MaterialID = int.Parse(ddlMaterial.SelectedValue.ToString());
                productModel.ProductItems.FormulaID = int.Parse(ddlFormula.SelectedValue.ToString());
                productModel.ProductItems.InsertBy = 1;

                productModel.ProductItemsBll.Insert(productModel.ProductItems);
                InitiateProductItems();
                Clear();
                this.radValidationProvider1.ClearErrorStatus();
            }
        }

        private void Clear()
        {
            lblProductItemID.Text = "";
            productPictureBox.Image = null;
        }

        private void InitiateProductItems()
        {
            var list1 = productModel.ProductItemsBll.GetAll();
            productitemsGridView.DataSource = list1;
                
        }

        private void productitemsGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            productModel.ProductItems = (ProductItems)productitemsGridView.Rows[rowindex].DataBoundItem;
            if (productModel.ProductItems != null)
            {
                lblProductItemID.Text = productModel.ProductItems.ProductItemsID.ToString();
                lblproductID.Text = productModel.ProductItems.Products.ProductID.ToString();
                ddlFormula.SelectedValue = productModel.ProductItems.Formula.FormulaID;
                ddlFormula.Text = productModel.ProductItems.Formula.FormulaType;
                ddlMaterial.SelectedValue = productModel.ProductItems.Materials.MaterialID;
                ddlMaterial.Text = productModel.ProductItems.Materials.Name;
                if (productModel.ProductItems.Products.Picture?.Length > 0)
                    productPictureBox.Image = ConvertToImage(productModel.ProductItems.Products.Picture);
                else
                    productPictureBox.Image = null;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (productPictureBox.Image == null)
                MessageBox.Show("Picture box can't be empty!");
            else
            {
                productModel.ProductItems.ProductItemsID = int.Parse(lblProductItemID.Text);
                productModel.ProductItems.MaterialID = int.Parse(ddlMaterial.SelectedValue.ToString());
                productModel.ProductItems.ProductID = int.Parse(lblproductID.Text);
                productModel.ProductItems.FormulaID = int.Parse(ddlFormula.SelectedValue.ToString());
                productModel.ProductItems.LUB = 1;

                if (productModel.ProductItemsBll.Update(productModel.ProductItems))
                {
                    MessageBox.Show("Product Item uppdated successfully!");
                    InitiateProductItems();
                    Clear();
                    this.radValidationProvider1.ClearErrorStatus();
                }
                else
                    MessageBox.Show("Something went wrong!");
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblProductItemID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (productModel.ProductItemsBll.Delete(int.Parse(lblProductItemID.Text)))
                    {
                        MessageBox.Show("Product Item deleted successfully!");
                        InitiateProductItems();
                        Clear();
                    }
                    else
                        MessageBox.Show("Shomething went wrong!");
                    
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
