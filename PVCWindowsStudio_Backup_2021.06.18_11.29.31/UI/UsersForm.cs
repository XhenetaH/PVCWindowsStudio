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
    public partial class UsersForm : Telerik.WinControls.UI.RadForm
    {
        private RoleBLL roleBll;
        private Users user;
        private UsersBLL userBll;
        public UsersForm()
        {
            user = new Users();
            userBll = new UsersBLL();
            roleBll = new RoleBLL();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.UserName = txtName.Text;
            user.Password = txtPassword.Text;
            if (roleddlist.SelectedValue == null)
                user.RoleID = -1;
            else
                user.RoleID = int.Parse(roleddlist.SelectedValue.ToString());
            user.InsertBy = 1;
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtPassword.Text) && user.RoleID >= 0)
            {
                userBll.Insert(user);
            }
            this.radValidationProvider1.Validate(txtName);
            this.radValidationProvider1.Validate(txtPassword);
            this.radValidationProvider1.Validate(roleddlist);
            Clear();
            InitiateData();
        }

        private void Clear()
        {
            lblID.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            roleddlist.SelectedIndex = -1;
            
        }
        private void InitiateData()
        {
            var list = userBll.GetAll();
            usersGridView.DataSource = list;

        }
        private void UsersForm_Load(object sender, EventArgs e)
        {
            roleddlist.DataSource = roleBll.GetAll();
            roleddlist.DisplayMember = "Name";
            roleddlist.ValueMember = "RoleID";
            

            InitiateData();
            
        }

        private void usersGridView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            user = (Users)usersGridView.Rows[rowindex].DataBoundItem;
            if (user != null)
            {
                lblID.Text = user.UserID.ToString();
                txtName.Text = user.UserName;
                txtPassword.Text = user.Password;
                roleddlist.Text = user.Role.Name;
                roleddlist.SelectedValue = user.RoleID;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            user.UserID = int.Parse(lblID.Text);
            user.UserName = txtName.Text;
            user.Password = txtPassword.Text;
            if (roleddlist.SelectedValue == null)
                user.RoleID = -1;
            else
                user.RoleID = int.Parse(roleddlist.SelectedValue.ToString());
            user.LUB = 1;
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtPassword.Text) && user.RoleID >= 0)
            {
                userBll.Update(user);
            }
            this.radValidationProvider1.Validate(txtName);
            this.radValidationProvider1.Validate(txtPassword);
            this.radValidationProvider1.Validate(roleddlist);
            Clear();
            InitiateData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    userBll.Delete(int.Parse(lblID.Text));
                    InitiateData();
                    Clear();
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
