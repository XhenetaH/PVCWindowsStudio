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
    public partial class PriceListForm : Telerik.WinControls.UI.RadForm
    {
        private ProfileBLL profilebll;
        private MaterialBLL materialbll;
        private PriceList pricelist;
        private PriceListBLL pricelistbll;
        public PriceListForm()
        {
            profilebll = new ProfileBLL();
            materialbll = new MaterialBLL();
            pricelist = new PriceList();
            pricelistbll = new PriceListBLL();
            InitializeComponent();
        }


        private void InitiateData()
        {
            var list = pricelistbll.GetAll();
            pricelistGridView.DataSource = list;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            pricelist.ProfileID = int.Parse(ddlProfile.SelectedValue.ToString());
            pricelist.MaterialID = int.Parse(ddlMaterial.SelectedValue.ToString());
            pricelist.Price = Convert.ToDecimal(txtPrice.Text);
            pricelist.InsertBy = 1;
            if (pricelistbll.Insert(pricelist))
            {
                MessageBox.Show("Item inserted successfully!");
                InitiateData();
                Clear();

            }
            else
                MessageBox.Show("Something went wrong!");
            
        }

        private void Clear()
        {
            txtPrice.Text = "";
        }

        private void PriceListForm_Load(object sender, EventArgs e)
        {
            ddlMaterial.DataSource = materialbll.GetAll();
            ddlMaterial.DisplayMember = "Name";
            ddlMaterial.ValueMember = "MaterialID";

            ddlProfile.DataSource = profilebll.GetAll();
            ddlProfile.DisplayMember = "NameProf";
            ddlProfile.ValueMember = "ProfileID";

            InitiateData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pricelist.PriceListID = int.Parse(lblID.Text);
            pricelist.ProfileID = int.Parse(ddlProfile.SelectedValue.ToString());
            pricelist.MaterialID = int.Parse(ddlMaterial.SelectedValue.ToString());
            pricelist.Price = Convert.ToDecimal(txtPrice.Text);
            pricelist.LUB = 1;
            if (pricelistbll.Update(pricelist))
            {
                MessageBox.Show("Item updated successfully!");
                InitiateData();
                Clear();

            }
            else
                MessageBox.Show("Something went wrong!");
        }

        private void pricelistGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            pricelist = (PriceList)pricelistGridView.Rows[rowindex].DataBoundItem;
            if (pricelist != null)
            {
                lblID.Text = pricelist.PriceListID.ToString();
                ddlMaterial.Text = pricelist.Materials.Name;
                ddlMaterial.SelectedValue = pricelist.MaterialID;
                ddlProfile.Text = pricelist.Profiles.NameProf;
                ddlProfile.SelectedValue = pricelist.ProfileID;
                txtPrice.Text = pricelist.Price.ToString();
            }
        }
    }
}
