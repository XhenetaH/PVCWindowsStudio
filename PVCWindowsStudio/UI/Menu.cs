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
            panelChildForm.Visible = true;
        }
        private void Dashboard2_Load(object sender, EventArgs e)
        {
            lblUserName.Text = UserSession.CurrentUser.UserName;
            lblUserStatus.Text = "Status: " + UserSession.CurrentUser.Role.Name;
        }

        private void dashboard2MenuItem_Click(object sender, EventArgs e)
        {
            panelChildForm.Visible = false;
        }

        private void calculatorMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new CalculatorForm());
        }

        private void orderMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }

        private void orderDetailsMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderDetailsForm());
        }

        private void invoicesMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new InvoiceForm());
        }

        private void clientsMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ClientsForm());
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            LogInForm login = new LogInForm();
            login.Show();
            this.Hide();
        }
    }
}
