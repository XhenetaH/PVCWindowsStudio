using PVCWindowsStudio.BLL;
using PVCWindowsStudio.BO;
using PVCWindowsStudio.Session;
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
        private readonly MaterialBLL materialBll;
        public MaterialsForm()
        {
            material = new Materials();
            materialBll = new MaterialBLL();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                material.Name = txtName.Text;
                material.Other = txtDescription.Text;
                material.InsertBy = 1;
                if (materialBll.Insert(material))
                {
                    Clear();
                    InitiateData();
                    this.radValidationProvider1.ClearErrorStatus();
                }
                else MessageBox.Show("Something went wrong!");
            }
            else this.radValidationProvider1.Validate(txtName);
            
        }
        private void Clear()
        {
            txtName.Text = "";
            txtDescription.Text = "";
            lblID.Text = "";
        }

        private void InitiateData()
        {
            materialGridView.DataSource = materialBll.GetAll();
        }

     
        private void MaterialsForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                
                if (!String.IsNullOrEmpty(txtName.Text))
                {
                    material.MaterialID = int.Parse(lblID.Text);
                    material.Name = txtName.Text;
                    material.Other = txtDescription.Text;
                    material.LUB = 1;
                    if (materialBll.Update(material))
                    {
                        MessageBox.Show("Material is updated successfully");
                        Clear();
                        InitiateData();
                        this.radValidationProvider1.ClearErrorStatus();
                    }
                    else MessageBox.Show("Something went wrong!");
                }
                else this.radValidationProvider1.Validate(txtName);
            }
            else
                MessageBox.Show("Please select an material!");
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
                    if (materialBll.Delete(int.Parse(lblID.Text)))
                    {
                        MessageBox.Show("Material is deleted successfully!");
                        InitiateData();
                        Clear();
                    }
                    else MessageBox.Show("Something went wrong!");
                }

            }
            else
                MessageBox.Show("Please select an material!");

        }

        private void materialGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
                material = (Materials)materialGridView.Rows[rowindex].DataBoundItem;
                if (material != null)
                {
                    lblID.Text = material.MaterialID.ToString();
                    txtName.Text = material.Name;
                    txtDescription.Text = material.Other;
                }
            }
        }
    }
}
