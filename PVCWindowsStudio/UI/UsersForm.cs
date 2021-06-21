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
        private readonly RoleBLL roleBll;
        private Users user;
        private readonly UsersBLL userBll;
        public UsersForm()
        {
            user = new Users();
            userBll = new UsersBLL();
            roleBll = new RoleBLL();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtPassword.Text) && user.RoleID >= 0)
            {
                user.UserName = txtName.Text;
                user.Password = txtPassword.Text;
                if (roleddlist.SelectedValue == null)
                    user.RoleID = -1;
                else
                    user.RoleID = int.Parse(roleddlist.SelectedValue.ToString());
                user.InsertBy = 1;
                if (userBll.Insert(user))
                {
                    MessageBox.Show("User inserted successfully!");
                    Clear();
                    InitiateData();
                }
                else MessageBox.Show("Something went wrong!");
            }
            else
            {
                this.radValidationProvider1.Validate(txtName);
                this.radValidationProvider1.Validate(txtPassword);
                this.radValidationProvider1.Validate(roleddlist);
            }            
        }

        private void Clear()
        {
            lblID.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
            roleddlist.SelectedIndex = -1;
            roleddlist.Text = "Select a role";
        }
        private void InitiateData()
        {
            usersGridView.DataSource = userBll.GetAll();
        }
        private void UsersForm_Load(object sender, EventArgs e)
        {
            roleddlist.DataSource = roleBll.GetAll();
            roleddlist.DisplayMember = "Name";
            roleddlist.ValueMember = "RoleID";
            roleddlist.Text = "Select a role";
            

            InitiateData();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {                
                if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtPassword.Text) && user.RoleID >= 0)
                {
                    user.UserID = int.Parse(lblID.Text);
                    user.UserName = txtName.Text;
                    user.Password = txtPassword.Text;
                    if (roleddlist.SelectedValue == null)
                        user.RoleID = -1;
                    else
                        user.RoleID = int.Parse(roleddlist.SelectedValue.ToString());
                    user.LUB = 1;
                    if (userBll.Update(user))
                    {
                        MessageBox.Show("User is updated successfully!");
                        Clear();
                        InitiateData();
                    }
                    else MessageBox.Show("Something went wrong!");
                }
                else
                {
                    this.radValidationProvider1.Validate(txtName);
                    this.radValidationProvider1.Validate(txtPassword);
                    this.radValidationProvider1.Validate(roleddlist);
                }
            }
            else MessageBox.Show("Please select an user!");
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
            else MessageBox.Show("Please select a user!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void usersGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
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
        }
    }
}
