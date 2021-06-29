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
    public partial class LogInForm : Telerik.WinControls.UI.RadForm
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPasword.Text;
            if (username.Trim() != "" && password != "")
            {
                Users user = UsersBLL.Login(username, password);
                if (user != null)
                {
                    UserSession.CurrentUser = user;
                   
                    if(user.Role.Name == "Admin")
                    {
                        AdminMenu adminDash = new AdminMenu();
                        adminDash.Show();
                    }
                    else
                    {
                        Menu admin = new Menu();
                        admin.Show();
                    }
                    
                    this.Hide();



                }
                else
                {
                    RadMessageBox.ThemeName = "MaterialBlueGrey";
                    RadMessageBox.Show("Username or password is incorrect!");                 
                    Application.Exit();
                }
            }
        }
       

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ChangeLanguage change = new ChangeLanguage();
            change.UpdateConfig("language", "en");
            Application.Restart();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ChangeLanguage change = new ChangeLanguage();
            change.UpdateConfig("language", "sq");
            Application.Restart();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Lenovo\\Documents\\My HelpAndManual Projects\\NewProject.chm", HelpNavigator.Topic, "Login.htm");

        }
    }
}
