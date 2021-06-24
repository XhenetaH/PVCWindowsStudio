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
            Form background = new Form();
            using (LogIn loginFrm = new LogIn())
            {
                background.StartPosition = FormStartPosition.Manual;
                background.FormBorderStyle = FormBorderStyle.None;
                background.Opacity = .70d;
                background.BackColor = Color.Black;
                background.WindowState = FormWindowState.Maximized;
                background.TopMost = true;
                background.Location = this.Location;
                background.ShowInTaskbar = false;
                background.Show();
                loginFrm.Owner = background;

                if (loginFrm.ShowDialog() == DialogResult.Yes)
                {                    
                    background.Dispose();
                    if (UserSession.CurrentUser.Role.Name == "Admin")
                    {
                        materialsManagMenuItem.Visibility = ElementVisibility.Visible;
                        productsManagMenuItem.Visibility = ElementVisibility.Visible;
                        pricelistMenuItem.Visibility = ElementVisibility.Visible;
                        usersManagMenuItem.Visibility = ElementVisibility.Visible;
                    }
                }
                else
                    Application.Exit();
            }

        }

        

        private void materialMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new MaterialsForm());
        }

        private void paneMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new WindowPanesForm());
        }

        private void blindMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new BlindsForm());
        }

        private void profileMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ProfilesForm());
        }

        private void productItemMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ProductItemsForm());
        }

        private void formulaMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormulaForm());
        }

        private void userMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new UsersForm());
        }

        private void roleMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new RolesForm());
        }

        private void pricelistMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new PriceListForm());
        }

        private void orderMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderForm());
        }

        private void orderDetailsMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderDetailsForm());
        }

        private void calculatorMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new CalculatorForm());
        }
    }
}
