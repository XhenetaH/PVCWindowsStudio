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
    public partial class Menu : Telerik.WinControls.UI.RadForm
    {
        public Menu()
        {
            InitializeComponent();
        }
        
        private void openChildForm(Form chilForm)
        {
            Form activeForm = null;
            if (activeForm != null)
            {
                activeForm.Close();

            }
            activeForm = chilForm;
            activeForm.TopLevel = false;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            activeForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(activeForm);
            panelChildForm.Tag = activeForm;
            activeForm.BringToFront();
            activeForm.Left = (this.ClientSize.Width - activeForm.Width) / 2;
            activeForm.Top = (this.ClientSize.Height - activeForm.Height) / 2;
            activeForm.Show();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new MaterialsForm());
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            openChildForm(new BlindsForm());
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            openChildForm(new WindowPanesForm());
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfilesForm());
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductsForm());
        }

        private void radMenuItem6_Click(object sender, EventArgs e)
        {
            openChildForm(new UsersForm());
        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            openChildForm(new RolesForm());
        }

        private void Menu_Shown(object sender, EventArgs e)
        {
            LogIn loginfrm = new LogIn();

            if(loginfrm.ShowDialog() == DialogResult.OK)
            {
                loginfrm.Close();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
