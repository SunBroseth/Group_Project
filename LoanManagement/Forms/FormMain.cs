using LoanManagement.Data.Models;
using LoanManagement.Data.Services;
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
        FormLoanTransaction formLoanTransaction;
        FormDashboard formDashboard;
        FormCollateral formCollateral;
        FormCreditOfficer formCreditOfficer;
        DataTable dtUserPermission;
        FormCustomer formCustomer;
        FormUserManangement formUserManangement;

        public AppUser userLogon { get; set; }

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

        private void pUser_Click(object sender, EventArgs e)
        {
            pUser.BackColor = Color.Black;
            lblUser.ForeColor = Color.White;
        
            if (formUserManangement == null)
            {
                formUserManangement = new FormUserManangement(this);
                formUserManangement.TopLevel = false;

                formUserManangement.FormBorderStyle = FormBorderStyle.None;
                formUserManangement.Dock = DockStyle.Fill;


                pnMain.Controls.Add(formUserManangement);
                formUserManangement.Show();
                formUserManangement.BringToFront();
            }
            else
            {
                formUserManangement.BringToFront();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            if (this.userLogon.IsHidden)
            {
                pUser.Visible = true;
            }
            else
            {
                pUser.Visible = false;
            }


            
            dtUserPermission = AppUserPermissionService.Get(this.userLogon.AppUserId);

            foreach (DataRow dataRow in dtUserPermission.Rows)
            {
                if (dataRow["UserPermission"].ToString() == "CustomerView")
                {
                    pCustomer.Visible = true;
                }

                if (dataRow["UserPermission"].ToString() == "DashboardView")
                {
                    pDashboard.Visible = true;
                }

                if (dataRow["UserPermission"].ToString() == "CreditOfficerView")
                {
                    pCreditOfficer.Visible = true;
                }

                if (dataRow["UserPermission"].ToString() == "CollateralView")
                {
                    pCollateral.Visible = true;
                }

                if (dataRow["UserPermission"].ToString() == "LoanView")
                {
                    pLoan.Visible = true;
                }



            }
        }

        private void pLogOut_MouseEnter(object sender, EventArgs e)
        {
            pLogOut.BackColor = Color.Black;
            
        }

        private void pLogOut_MouseLeave(object sender, EventArgs e)
        {
            pLogOut.BackColor = Color.FromArgb(0, 119, 182);
        }

        private void pLogOut_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(LoginForm));
            t.Start();
            this.Close();
        }
        public static void LoginForm()
        {
            Application.Run(new FormLogin());
        }

        private void pCreditOfficer_Click(object sender, EventArgs e)
        {
            if (formCreditOfficer == null)
            {
                formCreditOfficer = new FormCreditOfficer(this);
                formCreditOfficer.TopLevel = false;

                formCreditOfficer.FormBorderStyle = FormBorderStyle.None;
                formCreditOfficer.Dock = DockStyle.Fill;


                pnMain.Controls.Add(formCreditOfficer);
                formCreditOfficer.Show();
                formCreditOfficer.BringToFront();
            }
            else
            {
                formCreditOfficer.BringToFront();
            }
        }

        private void pCollateral_Click(object sender, EventArgs e)
        {
           
            if (formCollateral == null)
            {
                formCollateral = new FormCollateral(this);
                formCollateral.TopLevel = false;

                formCollateral.FormBorderStyle = FormBorderStyle.None;
                formCollateral.Dock = DockStyle.Fill;


                pnMain.Controls.Add(formCollateral);
                formCollateral.Show();
                formCollateral.BringToFront();
            }
            else
            {
                formCollateral.BringToFront();
            }
        }

        private void pDashboard_Click(object sender, EventArgs e)
        {
            if (formDashboard == null)
            {
                formDashboard = new FormDashboard(this);
                formDashboard.TopLevel = false;

                formDashboard.FormBorderStyle = FormBorderStyle.None;
                formDashboard.Dock = DockStyle.Fill;


                pnMain.Controls.Add(formDashboard);
                formDashboard.Show();
                formDashboard.BringToFront();
            }
            else
            {
                formDashboard.BringToFront();
            }
        }

        private void pLoan_Click(object sender, EventArgs e)
        {
            if (formLoanTransaction == null)
            {
                formLoanTransaction = new FormLoanTransaction(this);
                formLoanTransaction.TopLevel = false;

                formLoanTransaction.FormBorderStyle = FormBorderStyle.None;
                formLoanTransaction.Dock = DockStyle.Fill;


                pnMain.Controls.Add(formLoanTransaction);
                formLoanTransaction.Show();
                formLoanTransaction.BringToFront();
            }
            else
            {
                formLoanTransaction.BringToFront();
            }
        }
    }
}
