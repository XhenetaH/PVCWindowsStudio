using PVCWindowsStudio.BLL;
using PVCWindowsStudio.BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace PVCWindowsStudio.UI
{
    public partial class ProfilesForm : Telerik.WinControls.UI.RadForm
    {
        private Profiles profile;
        private readonly ProfileBLL profileBll;
        public ProfilesForm()
        {
            profile = new Profiles();
            profileBll = new ProfileBLL();
            InitializeComponent();
        }

        private void ProfilesForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void InitiateData()
        {
            profileGridView.DataSource = profileBll.GetAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {            
            if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtColor.Text))
            {
                profile.Name = txtName.Text;
                profile.Other = txtDescription.Text;
                profile.Color = txtColor.Text;
                profile.InsertBy = 1;
                if (profileBll.Insert(profile))
                {
                    MessageBox.Show("Profile inserted successfully!");
                    Clear();
                    InitiateData();
                    this.radValidationProvider1.ClearErrorStatus();
                }
                else MessageBox.Show("Something went wrong!");
            }
            else
            {
                this.radValidationProvider1.Validate(txtName);
                this.radValidationProvider1.Validate(txtColor);
            }
            
        }
        private void Clear()
        {
            this.radValidationProvider1.ClearErrorStatus();
            txtName.Text = "";
            txtDescription.Text = "";
            txtColor.Text = "";
            lblID.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (!String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtDescription.Text))
                {
                    profile.Name = txtName.Text;
                    profile.Other = txtDescription.Text;
                    profile.Color = txtColor.Text;
                    profile.LUB = 1;
                    if (profileBll.Update(profile))
                    {
                        MessageBox.Show("Profile updated successfully!");
                        Clear();
                        InitiateData();
                        this.radValidationProvider1.ClearErrorStatus();
                    }
                    else MessageBox.Show("Something went wrong!");
                }
                else
                {
                    this.radValidationProvider1.Validate(txtName);
                    this.radValidationProvider1.Validate(txtColor);
                }
                
            }
            else MessageBox.Show("Please select a profile!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (profileBll.Delete(int.Parse(lblID.Text)))
                    {
                        MessageBox.Show("Profile deleted successfully!");
                        InitiateData();
                        Clear();
                    }
                    else MessageBox.Show("Something went wrong!");
                }
            }
            else MessageBox.Show("Please select a Profile!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void profileGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            this.radValidationProvider1.ClearErrorStatus();
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
                profile = (Profiles)profileGridView.Rows[rowindex].DataBoundItem;
                if (profile != null)
                {
                    lblID.Text = profile.ProfileID.ToString();
                    txtName.Text = profile.Name;
                    txtDescription.Text = profile.Other;
                    txtColor.Text = profile.Color;
                }
            }
        }
    }
}
