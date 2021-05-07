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
    public partial class MaterialsForm : Telerik.WinControls.UI.RadForm
    {
        private Materials material;
        private MaterialBLL materialBll;
        public MaterialsForm()
        {
            material = new Materials();
            materialBll = new MaterialBLL();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            material.Name = txtName.Text;
            material.Other = txtDescription.Text;
            material.InsertBy = 1;
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                materialBll.Insert(material);
            }
            this.radValidationProvider1.Validate(txtName);
            Clear();
            InitiateData();
        }
        private void Clear()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            lblID.Text = "";
        }

        private void InitiateData()
        {
            var list = materialBll.GetAll();
            materialGridView.DataSource = list;
        }

        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            material.Name = txtName.Text;
            material.Other = txtDescription.Text;
            material.LUB = 1;
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                materialBll.Update(material);
            }
            this.radValidationProvider1.Validate(txtName);
            Clear();
            InitiateData();
        }

        private void materialGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            material = (Materials)materialGridView.Rows[rowindex].DataBoundItem;
            if (material != null)
            {
                lblID.Text = material.MaterialID.ToString();
                txtName.Text = material.Name;
                txtDescription.Text = material.Other;
            }
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
                    materialBll.Delete(int.Parse(lblID.Text));
                    InitiateData();
                    Clear();
                }

            }

        }
    }
}
