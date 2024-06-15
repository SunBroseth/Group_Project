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
    public partial class FormLogin : Form
    {
        int loginCount;
        public FormLogin()
        {
            InitializeComponent();
        }

        bool Dovalidation()
        {
            bool result = true;
            if (txtUsername.Text.Trim() == "")
            {
                epUsername.SetError(txtUsername, "Please Enter Username");
                result = false;
            }

            if (txtPassword.Text.Trim() == "")
            {
                epPassword.SetError(txtPassword, "Please Enter Password");
                result = false;
            }
            return result;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Dovalidation())
            {
                AppUser user = AppUserService.Login(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (user == null)
                {
                    MessageBox.Show("Invalid Username and Password, Please Enter again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loginCount++;
                    if (loginCount > 3)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    FormMain formmain = new FormMain();
                    formmain.userLogon = user;
                    this.Hide();
                    formmain.ShowDialog();
                    this.Close();
                }
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void checkShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPass.Checked)
            {
                string a = txtPassword.Text;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
