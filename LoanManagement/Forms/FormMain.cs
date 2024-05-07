using LoanManagement.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoanManagement
{
    public partial class FormMain : Form
    {
        FormCustomer formCustomer;

        public FormMain()
        {
            InitializeComponent();
        }

        private void pDashboard_MouseEnter(object sender, EventArgs e)
        {
            pDashboard.BackColor = Color.Black;
            lblDashboard.ForeColor = Color.White;
        }

        private void pDashboard_MouseLeave(object sender, EventArgs e)
        {
            pDashboard.BackColor = Color.FromArgb(202, 240, 248);
            lblDashboard.ForeColor = Color.Black;
        }

        private void pCustomer_MouseEnter(object sender, EventArgs e)
        {
            pCustomer.BackColor = Color.Black;
            lblCustomer.ForeColor = Color.White;
        }

        private void pCustomer_MouseLeave(object sender, EventArgs e)
        {
            pCustomer.BackColor = Color.FromArgb(202, 240, 248);
            lblCustomer.ForeColor = Color.Black;
        }

        private void pCreditOfficer_MouseEnter(object sender, EventArgs e)
        {
            pCreditOfficer.BackColor = Color.Black;
            lblCreditOfficer.ForeColor = Color.White;
        }

        private void pCreditOfficer_MouseLeave(object sender, EventArgs e)
        {
            pCreditOfficer.BackColor = Color.FromArgb(202, 240, 248);
            lblCreditOfficer.ForeColor = Color.Black;
        }

        private void pCollateral_MouseEnter(object sender, EventArgs e)
        {
            pCollateral.BackColor = Color.Black;
            lblCollateral.ForeColor = Color.White;
        }

        private void pCollateral_MouseLeave(object sender, EventArgs e)
        {
            pCollateral.BackColor = Color.FromArgb(202, 240, 248);
            lblCollateral.ForeColor = Color.Black;
        }

        private void pLoan_MouseEnter(object sender, EventArgs e)
        {
            pLoan.BackColor = Color.Black;
            lblLoan.ForeColor = Color.White;
        }

        private void pLoan_MouseLeave(object sender, EventArgs e)
        {
            pLoan.BackColor = Color.FromArgb(202, 240, 248);
            lblLoan.ForeColor = Color.Black;
        }

        private void pUser_MouseEnter(object sender, EventArgs e)
        {
            pUser.BackColor = Color.Black;
            lblUser.ForeColor = Color.White;
        }

        private void pUser_MouseLeave(object sender, EventArgs e)
        {
            pUser.BackColor = Color.FromArgb(202, 240, 248);
            lblUser.ForeColor = Color.Black;
        }

        private void pCustomer_Click(object sender, EventArgs e)
        {
            if (formCustomer == null)
            {
                formCustomer = new FormCustomer(this);
                formCustomer.TopLevel = false;

                formCustomer.FormBorderStyle = FormBorderStyle.None;
                formCustomer.Dock = DockStyle.Fill;


                pnMain.Controls.Add(formCustomer);
                formCustomer.Show();
                formCustomer.BringToFront();
            }
            else
            {
                formCustomer.BringToFront();
            }
        }
    }
}
