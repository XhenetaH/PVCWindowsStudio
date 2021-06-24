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
    public partial class RolesForm : Telerik.WinControls.UI.RadForm
    {
        private Roles role;
        private readonly RoleBLL roleBll;
        public RolesForm()
        {
            role = new Roles();
            roleBll = new RoleBLL();
            InitializeComponent();
            
        }

        private void InitiateData()
        {
            var list = roleBll.GetAll();
            roleGridView.DataSource = list;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {                            
            if(!String.IsNullOrEmpty(txtName.Text))
            {
                role.Name = txtName.Text;
                role.InsertBy = 1;
                if(roleBll.Insert(role))
                {
                    RadMessageBox.Show("Role inserted successfully!");
                    Clear();
                    InitiateData();
                    this.radValidationProvider1.ClearErrorStatus();
                }
            }
            else this.radValidationProvider1.Validate(txtName);
            
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            InitiateData();
            RadMessageBox.SetThemeName("MaterialBlueGrey");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (!String.IsNullOrEmpty(txtName.Text))
                {
                    role.Name = txtName.Text;
                    role.LUB = 1;

                    if (roleBll.Update(role))
                    {
                        RadMessageBox.Show("Role updated successfully!");
                        Clear();
                        InitiateData();
                        this.radValidationProvider1.ClearErrorStatus();
                    }
                    else RadMessageBox.Show("Something went wrong!");
                }
                else this.radValidationProvider1.Validate(txtName);
            }
            else RadMessageBox.Show("Please select a role!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (RadMessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    if (roleBll.Delete(int.Parse(lblID.Text)))
                    {
                        RadMessageBox.Show("Role is deleted successfully!");
                        InitiateData();
                        Clear();
                    }
                    else RadMessageBox.Show("Something went wrong!");
                }
            }
            else RadMessageBox.Show("Please select a role!");

        }


        private void Clear()
        {
            this.radValidationProvider1.ClearErrorStatus();
            txtName.Text = "";
            lblID.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void roleGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {           
            this.radValidationProvider1.ClearErrorStatus();
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
                role = (Roles)roleGridView.Rows[rowindex].DataBoundItem;
                if (role != null)
                {
                    lblID.Text = role.RoleID.ToString();
                    txtName.Text = role.Name;
                }
            }
        }
    }
}
