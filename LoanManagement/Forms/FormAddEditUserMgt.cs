using LoanManagement.Data.Models;
using LoanManagement.Data.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagement.Forms
{
    public partial class FormAddEditUserMgt : Form
    {
        AppUser appUser;
        bool IsNew;
        public FormAddEditUserMgt(AppUser user)
        {
            InitializeComponent();
            if (user == null)
            {
                lblTitle.Text = "New User";
                this.appUser = new AppUser();
                IsNew = true;
            }
            else
            {
                lblTitle.Text = "Edit User";
                btnSave.Text = "Update";
                txtUsername.Text = user.UserName;
                txtPassword.Text = user.Password;
                txtConfirmPassword.Text = user.Password;
                this.appUser = user;
                IsNew = false;
            }
        }

        bool DoValidation()
        {
            bool result = true;
            if (txtUsername.Text.Trim() == "")
            {
                epUsername.SetError(txtUsername, "Please enter username");
                result = false;
            }

            if (txtPassword.Text.Length < 4)
            {
                epPassword.SetError(txtPassword, "Please enter password");
                result = false;
            }

            if (txtConfirmPassword.Text.Trim() != txtConfirmPassword.Text.Trim())
            {
                epConfPassword.SetError(txtConfirmPassword, "Please enter confirm password");
                result = false;
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DoValidation())
            {
                appUser.UserName = txtUsername.Text.Trim();
                appUser.Password = txtPassword.Text.Trim();
                if (IsNew)
                {
                    AppUserService.Add(appUser);
                }
                else
                {
                    AppUserService.Update(appUser);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
