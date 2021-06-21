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
        private readonly ClientBLL clientBll;
        private Clients client;
        public ClientsForm()
        {
            clientBll = new ClientBLL();
            client = new Clients();
            InitializeComponent();
        }
        private void InitiateData()
        {
            clientGridView1.DataSource = clientBll.GetAll();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                client.Name = txtName.Text;
                client.LastName = txtLastName.Text;
                client.PhoneNumber = txtPhoneNr.Text;
                client.Email = txtEmail.Text;
                client.Address = txtAddress.Text;
                client.InsertBy = 1;
                if (clientBll.Insert(client))
                {
                    MessageBox.Show("Client is inserted successfully!");
                    Clear();
                    InitiateData();
                    this.radValidationProvider1.ClearErrorStatus();
                }
                else MessageBox.Show("Something went wrong!");
            }
            else this.radValidationProvider1.Validate(txtName);            
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {                
                if (!String.IsNullOrEmpty(txtName.Text))
                {
                    client.Name = txtName.Text;
                    client.LastName = txtLastName.Text;
                    client.PhoneNumber = txtPhoneNr.Text;
                    client.Email = txtEmail.Text;
                    client.Address = txtAddress.Text;
                    client.LUB = 1;
                    if (clientBll.Update(client))
                    {
                        MessageBox.Show("Client is updated successfully!");
                        Clear();
                        InitiateData();
                        this.radValidationProvider1.ClearErrorStatus();
                    }
                    else MessageBox.Show("Something went wrong!");
                }
                else this.radValidationProvider1.Validate(txtName);                
            }
            else MessageBox.Show("Please select a client!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (clientBll.Delete(int.Parse(lblID.Text)))
                    {
                        MessageBox.Show("Client is deleted successfully!");
                        InitiateData();
                        Clear();
                    }
                    else MessageBox.Show("Something went wrong!");
                }
            }
            else
                MessageBox.Show("Please select a client!");
        }

        private void Clear()
        {
            this.radValidationProvider1.ClearErrorStatus();
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
      
        private void clientGridView1_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.radValidationProvider1.ClearErrorStatus();
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
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
}
