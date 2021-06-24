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
    public partial class LogIn : Telerik.WinControls.UI.RadForm
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if(username.Trim()!=""&&password!="")
            {
                Users user = UsersBLL.Login(username, password);
                if(user!=null)
                {
                    UserSession.CurrentUser = user;
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect!");
                    Application.Exit();
                }
            }
           
        }
    }
}
