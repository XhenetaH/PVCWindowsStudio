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
            chilForm.TopLevel = false;
            chilForm.FormBorderStyle = FormBorderStyle.None;
            chilForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(chilForm);
            panelChildForm.Tag = chilForm;
            chilForm.BringToFront();
            chilForm.Left = (this.ClientSize.Width - chilForm.Width) / 2;
            chilForm.Top = (this.ClientSize.Height - chilForm.Height) / 2;
            chilForm.Show();
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            openChildForm(new LogIn());
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new MaterialsForm());
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            openChildForm(new BlindsForm());
        }
    }
}
