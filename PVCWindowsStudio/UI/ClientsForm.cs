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
    public partial class ClientsForm : Telerik.WinControls.UI.RadForm
    {
        private ClientBLL clientBll;
        private Clients client;
        public ClientsForm()
        {
            clientBll = new ClientBLL();
            client = new Clients();
            InitializeComponent();
        }
        private void InitiateData()
        {
            var list = clientBll.GetAll();
            clientGridView1.DataSource = list;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            client.Name = txtName.Text;
            client.LastName = txtLastName.Text;
            client.PhoneNumber = txtPhoneNr.Text;
            client.Email = txtEmail.Text;
            client.Address = txtAddress.Text;
            client.InsertBy = 1;
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                clientBll.Insert(client);
            }
            this.radValidationProvider1.Validate(txtName);
            Clear();
            InitiateData();
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            client.Name = txtName.Text;
            client.LastName = txtLastName.Text;
            client.PhoneNumber = txtPhoneNr.Text;
            client.Email = txtEmail.Text;
            client.Address = txtAddress.Text;
            client.LUB = 1;
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                clientBll.Update(client);
            }
            this.radValidationProvider1.Validate(txtName);
            Clear();
            InitiateData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clientBll.Delete(int.Parse(lblID.Text));
                    InitiateData();
                    Clear();
                }

            }
        }

        private void Clear()
        {
            txtName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhoneNr.Text = "";
            txtAddress.Text = "";
            lblID.Text = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void clientGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            client = (Clients)clientGridView1.Rows[rowindex].DataBoundItem;
            if (client != null)
            {
                lblID.Text = client.ClientID.ToString();
                txtName.Text = client.Name;
                txtLastName.Text = client.LastName;
                txtAddress.Text = client.Address;
                txtEmail.Text = client.Email;
                txtPhoneNr.Text = client.PhoneNumber;
            }
        }
    }
}
