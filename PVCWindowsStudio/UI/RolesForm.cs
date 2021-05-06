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
        private RoleBLL roleBll;
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
  
            roleGridView.Columns[0].IsVisible = false;
            roleGridView.Columns[2].IsVisible = false;
            roleGridView.Columns[0].TextAlignment = ContentAlignment.MiddleCenter;
            roleGridView.Columns[1].TextAlignment = ContentAlignment.MiddleCenter;
            roleGridView.Columns[2].TextAlignment = ContentAlignment.MiddleCenter;
            roleGridView.Columns[3].TextAlignment = ContentAlignment.MiddleCenter;
            roleGridView.Columns[4].TextAlignment = ContentAlignment.MiddleCenter;
            roleGridView.Columns[5].TextAlignment = ContentAlignment.MiddleCenter;
            roleGridView.Columns[6].TextAlignment = ContentAlignment.MiddleCenter;
            roleGridView.Columns[7].TextAlignment = ContentAlignment.MiddleCenter;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            role.Name = txtName.Text;
            role.InsertBy = 1;                   
            if(!String.IsNullOrEmpty(txtName.Text))
            {
                roleBll.Insert(role);
                InitiateData();
                
            }
            this.radValidationProvider1.Validate(txtName);
            Clear();
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            role.Name = txtName.Text;
            role.LUB = 1;
            if(!String.IsNullOrEmpty(txtName.Text))
            {
                roleBll.Update(role);
                InitiateData();
            }
            this.radValidationProvider1.Validate(txtName);
            Clear();
        }

        private void roleGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            role = (Roles)roleGridView.Rows[rowindex].DataBoundItem;
            if (role != null)
            {
                lblID.Text = role.RoleID.ToString();
                txtName.Text = role.Name;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(lblID.Text))
            {
                if(MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    roleBll.Delete(int.Parse(lblID.Text));
                    InitiateData();
                    Clear();
                }
              
            }

        }


        private void Clear()
        {
            txtName.Text = "";
            lblID.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
