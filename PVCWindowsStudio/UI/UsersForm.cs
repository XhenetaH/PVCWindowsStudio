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
using Telerik.WinControls.UI;

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
        private bool ValidationMethod()
        {
            bool valid = true;
            if (this.radValidationProvider1.ValidationMode == ValidationMode.Programmatically)
            {
                foreach (Control control in this.radPanel5.Controls)
                {
                    RadEditorControl editorControl = control as RadEditorControl;
                    if (editorControl != null)
                    {
                        this.radValidationProvider1.Validate(editorControl);
                        var mode = this.radValidationProvider1.AssociatedControls;
                        foreach (var i in mode)
                        {
                            if (string.IsNullOrEmpty(i.AccessibilityObject.Value.ToString()))
                                valid = false;
                        }
                    }
                }
            }
            return valid;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (ValidationMethod())
            {
                user.UserName = txtName.Text;
                user.Password = txtPassword.Text;
                user.RoleID = int.Parse(roleddlist.SelectedValue.ToString());
                user.InsertBy = UserSession.CurrentUser.UserID;
                    
                if (userBll.Insert(user))
                {
                    RadMessageBox.Show("User inserted successfully!");
                    Clear();
                    InitiateData();
                }
                else RadMessageBox.Show("Something went wrong!");
            }    
        }

        private void Clear()
        {
            lblID.Text = "";
            txtName.Text = "";
            txtPassword.Text = "";
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
            

            InitiateData();
            RadMessageBox.SetThemeName("MaterialBlueGrey");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {                
                if (ValidationMethod())
                {
                    user.UserID = int.Parse(lblID.Text);
                    user.UserName = txtName.Text;
                    user.Password = txtPassword.Text;
                    user.RoleID = int.Parse(roleddlist.SelectedValue.ToString());
                    user.LUB = UserSession.CurrentUser.UserID;
                    if (userBll.Update(user))
                    {
                        RadMessageBox.Show("User is updated successfully!");
                        Clear();
                        InitiateData();
                    }
                    else RadMessageBox.Show("Something went wrong!");                
                }
            }
            else RadMessageBox.Show("Please select an user!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (RadMessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    userBll.Delete(int.Parse(lblID.Text));
                    InitiateData();
                    Clear();
                }

            }
            else RadMessageBox.Show("Please select a user!");
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

        

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Lenovo\\Documents\\My HelpAndManual Projects\\NewProject.chm", HelpNavigator.Topic, "Users.htm");

        }

        private void btnAmerican_Click(object sender, EventArgs e)
        {
            ChangeLanguage change = new ChangeLanguage();
            change.UpdateConfig("language", "en");
            Application.Restart();
        }

        private void btnAlbania_Click_1(object sender, EventArgs e)
        {
            ChangeLanguage change = new ChangeLanguage();
            change.UpdateConfig("language", "sq");
            Application.Restart();
        }
    }
}
