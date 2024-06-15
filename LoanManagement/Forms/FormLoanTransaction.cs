using LoanManagement.Data.Services;
using LoanManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoanManagement.Forms
{
    public partial class FormLoanTransaction : Form
    {
        
        DataTable dtLoan;
        DataTable dtLoanDetail;

        BindingSource bsLoan;
        FormMain formMain;
        public FormLoanTransaction(FormMain frmMain)
        {
            formMain = frmMain;
            InitializeComponent();

            InitializeData();


        }

        void LoadCustomer()
        {
            DataTable dtCustomer = CustomerService.GetAll();
            cboCustomer.DataSource = dtCustomer;
            cboCustomer.DisplayMember = "CustomerName";
            cboCustomer.ValueMember = "CustomerId";
        }

        void LoadCreditOfficer()
        {
            DataTable dtCreditOfficer = CreditOfficerService.GetAll();
            cboCreditOfficer.DataSource = dtCreditOfficer;
            cboCreditOfficer.DisplayMember = "CreditOfficerName";
            cboCreditOfficer.ValueMember = "CreditOfficerId";
        }
        void LoadCollateral()
        {
            DataTable dtCollateral = CollateralService.GetAll();
            cboCollateral.DataSource = dtCollateral;
            cboCollateral.DisplayMember = "CollateralCode";
            cboCollateral.ValueMember = "CollateralId";
        }

        void AllowEditPurchase(bool value)
        {
            cboCustomer.Enabled = value;
            cboCollateral.Enabled = value;
            cboCreditOfficer.Enabled = value;
            dtLoanDate.Enabled = value;
            txtLoanCode.Enabled = value;
            txtLoanAmount.Enabled = value;
            txtCurrency.Enabled = value;
            txtInterestRate.Enabled = value;
            txtPaymentFrequencyCode.Enabled = value;
            txtMemo.Enabled = value;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            bsLoan.AddNew();
            dtLoanDetail.Rows.Clear();

            cboCustomer.Enabled=true;
            cboCollateral.Enabled=true;
            cboCreditOfficer.Enabled=true;
            dtLoanDate.Enabled=true;
            txtLoanCode.ReadOnly=false;
            txtLoanAmount.ReadOnly=false;
            txtCurrency.ReadOnly=false;
            txtInterestRate.ReadOnly=false;
            txtPaymentFrequencyCode.ReadOnly=false;
            txtMemo.ReadOnly=false;
            btnBackward.Visible = false;
            btnForward.Visible = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
           
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            dgLoanDetail.Enabled = true;
        }

        void LoadLoan()
        {
            dtLoan = LoanService.GetAll();
            bsLoan = new BindingSource();
            bsLoan.DataSource = dtLoan;

            txtLoanId.DataBindings.Clear();
            txtLoanId.DataBindings.Add(new Binding("Text", bsLoan, "LoanId"));

            cboCustomer.DataBindings.Clear();
            cboCustomer.DataBindings.Add(new Binding("SelectedValue", bsLoan, "CustomerId"));
            cboCollateral.DataBindings.Clear();
            cboCollateral.DataBindings.Add(new Binding("SelectedValue", bsLoan, "CollateralId"));
            cboCreditOfficer.DataBindings.Clear();
            cboCreditOfficer.DataBindings.Add(new Binding("SelectedValue", bsLoan, "CreditOfficerId"));
            dtLoanDate.DataBindings.Clear();
            dtLoanDate.DataBindings.Add(new Binding("Text", bsLoan, "LoanDate", true));
            txtLoanCode.DataBindings.Clear();
            txtLoanCode.DataBindings.Add(new Binding("Text", bsLoan, "LoanCode"));
            txtLoanAmount.DataBindings.Clear();
            txtLoanAmount.DataBindings.Add(new Binding("Text", bsLoan, "LoanAmount"));
            txtCurrency.DataBindings.Clear();
            txtCurrency.DataBindings.Add(new Binding("Text", bsLoan, "Currency"));
            txtInterestRate.DataBindings.Clear();
            txtInterestRate.DataBindings.Add(new Binding("Text", bsLoan, "InterestRate"));
            txtPaymentFrequencyCode.DataBindings.Clear();
            txtPaymentFrequencyCode.DataBindings.Add(new Binding("Text", bsLoan, "PaymentFrequencyCode"));
            txtMemo.DataBindings.Clear();
            txtMemo.DataBindings.Add(new Binding("Text", bsLoan, "Memo"));

            LoadLoanDetail();

        }


        void LoadLoanDetail()
        {
            if (bsLoan.Count <= 0)
            {
                dtLoanDetail = LoanDetailService.Get(0);
            }
            else
            {
                DataRowView current = (DataRowView)bsLoan.Current;
                int purchaseid = Convert.ToInt32(current["LoanId"].ToString());
                dtLoanDetail = LoanDetailService.Get(purchaseid);
            }

            dgLoanDetail.Columns[0].Visible = false;
            dgLoanDetail.Columns[0].DataPropertyName = "LoanDetailId";

            dgLoanDetail.Columns[1].Visible = false;
            dgLoanDetail.Columns[1].DataPropertyName = "LoanId";

            dgLoanDetail.Columns[2].Visible = true;
            dgLoanDetail.Columns[2].HeaderText = "P.No";
            dgLoanDetail.Columns[2].Width = 50;
            dgLoanDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgLoanDetail.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgLoanDetail.Columns[2].DataPropertyName = "PeriodNo";

            

            dgLoanDetail.Columns[3].Visible = true;
            dgLoanDetail.Columns[3].HeaderText = "BegBal";
            dgLoanDetail.Columns[3].Width =150;
            dgLoanDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgLoanDetail.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgLoanDetail.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgLoanDetail.Columns[3].DefaultCellStyle.Format = "#,##0.00 $";
            dgLoanDetail.Columns[3].DataPropertyName = "BeginningBalance";

            dgLoanDetail.Columns[4].Visible = true;
            dgLoanDetail.Columns[4].HeaderText = "Principle";
            dgLoanDetail.Columns[4].Width = 150;
            dgLoanDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgLoanDetail.Columns[4].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgLoanDetail.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgLoanDetail.Columns[4].DefaultCellStyle.Format = "#,##0.00 $";
            dgLoanDetail.Columns[4].DataPropertyName = "Principle";

            dgLoanDetail.Columns[5].Visible = true;
            dgLoanDetail.Columns[5].HeaderText = "Interest";
            dgLoanDetail.Columns[5].Width = 150;
            dgLoanDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgLoanDetail.Columns[5].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgLoanDetail.Columns[5].DefaultCellStyle.Format = "#,##0.00 $";
            dgLoanDetail.Columns[5].DataPropertyName = "Interest";

            dgLoanDetail.Columns[6].Visible = true;
            dgLoanDetail.Columns[6].HeaderText = "Payment";
            dgLoanDetail.Columns[6].Width = 150;
            dgLoanDetail.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgLoanDetail.Columns[6].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgLoanDetail.Columns[6].DefaultCellStyle.Format = "#,##0.00 $";
            dgLoanDetail.Columns[6].DataPropertyName = "Payment";

            dgLoanDetail.Columns[7].Visible = true;
            dgLoanDetail.Columns[7].HeaderText = "EndBal";
            dgLoanDetail.Columns[7].Width = 150;
            dgLoanDetail.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgLoanDetail.Columns[7].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgLoanDetail.Columns[7].DefaultCellStyle.Format = "#,##0.00 $";
            dgLoanDetail.Columns[7].DataPropertyName = "EndingBalance";

            dgLoanDetail.Columns[8].Visible = true;
            dgLoanDetail.Columns[8].HeaderText = "IsPaid";
            dgLoanDetail.Columns[8].Width = 60;
            dgLoanDetail.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgLoanDetail.Columns[8].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgLoanDetail.Columns[8].DataPropertyName = "IsPaid";

            DataGridViewCheckBoxColumn column = (DataGridViewCheckBoxColumn)dgLoanDetail.Columns[8];

            


            dgLoanDetail.Columns[9].Visible = true;
            dgLoanDetail.Columns[9].HeaderText = "PaidDate";
            dgLoanDetail.Columns[9].Width = 150;
            dgLoanDetail.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgLoanDetail.Columns[9].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgLoanDetail.Columns[9].DataPropertyName = "PaidDate";

            dgLoanDetail.Columns[10].Visible = true;
            dgLoanDetail.Columns[10].HeaderText = "Note";
            dgLoanDetail.Columns[10].Width = 150;
            dgLoanDetail.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgLoanDetail.Columns[10].SortMode = DataGridViewColumnSortMode.NotSortable;
            dgLoanDetail.Columns[10].DataPropertyName = "Note";

            dgLoanDetail.DataSource = dtLoanDetail;
            
        }

        bool DoValidation()
        {
            bool result = true;
            if (cboCustomer.SelectedIndex < 0)
            {
                epCustomer.SetError(cboCustomer, "Please Enter Customer Name!");
                result = false;
            }
            return result;
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgLoanDetail.EndEdit();

           


            if (!DoValidation())
                return;

            DataRowView datarow = (DataRowView)bsLoan.Current;
            if (datarow.IsNew)
            {
                if (DoValidation())
                {
                    Loan loan = new Loan();
                    loan.CustomerId = Convert.ToInt32(cboCustomer.SelectedValue);
                    loan.CollateralId = Convert.ToInt32(cboCollateral.SelectedValue);
                    loan.CreditOfficerId = Convert.ToInt32(cboCreditOfficer.SelectedValue);
                    loan.LoanDate = dtLoanDate.Value;
                    loan.LoanCode = txtLoanCode.Text;
                    loan.LoanAmount = Convert.ToDouble(txtLoanAmount.Text);
                    loan.Currency = txtCurrency.Text;
                    loan.InterestRate = Convert.ToDouble(txtInterestRate.Text);
                    loan.PaymentFrequencyCode = Convert.ToInt32(txtPaymentFrequencyCode.Text);
                    loan.Memo = txtMemo.Text;
                    int loanid = LoanService.Add(loan);
                    if (loanid > 0)
                    {
                        dtLoanDetail.Columns["LoanId"].DefaultValue = loanid;
                        dgLoanDetail.Refresh();
                        dtLoanDetail.AcceptChanges();
                        foreach (DataRow row in dtLoanDetail.Rows)
                        {
                            LoanDetail loandetail = new LoanDetail();
                            loandetail.LoanId = loanid;
                            loandetail.PeriodNo = Convert.ToInt32(row["PeriodNo"].ToString());
                            loandetail.BeginningBalance = Convert.ToDouble(row["BeginningBalance"].ToString());
                            loandetail.Principle = Convert.ToDouble(row["Principle"].ToString());
                            loandetail.Interest = Convert.ToDouble(row["Interest"].ToString());
                            loandetail.Payment = Convert.ToDouble(row["Payment"].ToString());
                            loandetail.EndingBalance = Convert.ToDouble(row["EndingBalance"].ToString());

                            loandetail.IsPaid = Convert.ToBoolean(row["IsPaid"]);
                            loandetail.PaidDate = Convert.ToDateTime(row["PaidDate"].ToString());
                            loandetail.Note = row["Note"].ToString();
                           
                            LoanDetailService.Add(loandetail);
                        }
                    }
                    MessageBox.Show("Invoice has added successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLoan();
                }
            }
            else
            {
                if (DoValidation())
                {
                    Loan loan = new Loan();
                    loan.LoanId = Convert.ToInt32(txtLoanId.Text);
                    loan.CustomerId = Convert.ToInt32(cboCustomer.SelectedValue);
                    loan.CollateralId = Convert.ToInt32(cboCollateral.SelectedValue);
                    loan.CreditOfficerId = Convert.ToInt32(cboCreditOfficer.SelectedValue);
                    loan.LoanDate = dtLoanDate.Value;
                    loan.LoanCode = txtLoanCode.Text;
                    loan.LoanAmount = Convert.ToDouble(txtLoanAmount.Text);
                    loan.Currency = txtCurrency.Text;
                    loan.InterestRate = Convert.ToDouble(txtInterestRate.Text);
                    loan.PaymentFrequencyCode = Convert.ToInt32(txtPaymentFrequencyCode.Text);
                    loan.Memo = txtMemo.Text;
                    LoanService.Update(loan);

                    LoanDetailService.Delete(loan.LoanId);
                    dgLoanDetail.Refresh();
                    dtLoanDetail.AcceptChanges();

                    foreach (DataRow row in dtLoanDetail.Rows)
                    {
                        LoanDetail loandetail = new LoanDetail();
                        loandetail.LoanId = loan.LoanId;
                        loandetail.PeriodNo = Convert.ToInt32(row["PeriodNo"].ToString());
                        loandetail.BeginningBalance = Convert.ToDouble(row["BeginningBalance"].ToString());
                        loandetail.Principle = Convert.ToDouble(row["Principle"].ToString());
                        loandetail.Interest = Convert.ToDouble(row["Interest"].ToString());
                        loandetail.Payment = Convert.ToDouble(row["Payment"].ToString());
                        loandetail.EndingBalance = Convert.ToDouble(row["EndingBalance"].ToString());
                        loandetail.IsPaid = Convert.ToBoolean(row["IsPaid"]);
                        loandetail.PaidDate = Convert.ToDateTime(row["PaidDate"].ToString());
                        loandetail.Note = row["Note"].ToString();

                        LoanDetailService.Add(loandetail);
                    }
                    MessageBox.Show("Invoice has updated succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            LoadLoan();
            LoadLoanDetail();

            cboCustomer.Enabled = false;
            cboCollateral.Enabled = false;
            cboCreditOfficer.Enabled = false;
            dtLoanDate.Enabled = false;
            txtLoanCode.ReadOnly = true;
            txtLoanAmount.ReadOnly = true;
            txtCurrency.ReadOnly = true;
            txtInterestRate.ReadOnly = true;
            txtPaymentFrequencyCode.ReadOnly = true;
            txtMemo.ReadOnly = true;

            btnBackward.Visible = true;
            btnForward.Visible = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
           
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            dgLoanDetail.Enabled = false;
        }

        void InitializeData()
        {
           
            LoadCollateral();
            LoadCustomer();
            LoadCreditOfficer();
            LoadLoan();
            LoadLoanDetail();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            bsLoan.CancelEdit();

            cboCustomer.Enabled = false;
            cboCollateral.Enabled = false;
            cboCreditOfficer.Enabled = false;
            dtLoanDate.Enabled = false;
            txtLoanCode.ReadOnly = true;
            txtLoanAmount.ReadOnly = true;
            txtCurrency.ReadOnly = true;
            txtInterestRate.ReadOnly = true;
            txtPaymentFrequencyCode.ReadOnly = true;
            txtMemo.ReadOnly = true;
            btnBackward.Visible = true;
            btnForward.Visible = true;
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
      
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            dgLoanDetail.Enabled = false;
            InitializeData();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            bsLoan.CancelEdit();
            bsLoan.MoveNext();
            LoadLoanDetail();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            bsLoan.CancelEdit();
            bsLoan.MovePrevious();
            LoadLoanDetail();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cboCustomer.Enabled = true;
            cboCollateral.Enabled = true;
            cboCreditOfficer.Enabled = true;
            dtLoanDate.Enabled = true;
            txtLoanCode.ReadOnly = false;
            txtLoanAmount.ReadOnly = false;
            txtCurrency.ReadOnly = false;
            txtInterestRate.ReadOnly = false;
            txtPaymentFrequencyCode.ReadOnly = false;
            txtMemo.ReadOnly = false;
            btnBackward.Visible = false;
            btnForward.Visible = false;
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
           
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            dgLoanDetail.Enabled = true;
        }

        private void dgLoanDetail_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells["IsPaid"].Value = false;
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bsLoan.Count <= 0)
                return;
            DataRowView datarow = (DataRowView)bsLoan.Current;
            if (datarow.IsNew)
                return;

            DialogResult conf = MessageBox.Show("Are you sure to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (conf != DialogResult.Yes)
                return;
            LoanService.Delete(Convert.ToInt32(txtLoanId.Text));
            MessageBox.Show("Loan has deleted successfully");
            InitializeData();
        }

        private void FormLoanTransaction_Load(object sender, EventArgs e)
        {
            DataTable dtPermission = AppUserPermissionService.Get(formMain.userLogon.AppUserId);
            foreach (DataRow dr in dtPermission.Rows)
            {
                if (dr["UserPermission"].ToString() == "LoanCreate")
                {
                    btnNew.Visible = true;
                }

                if (dr["UserPermission"].ToString() == "LoanModify")
                {
                    btnEdit.Visible = true;
                }

                if (dr["UserPermission"].ToString() == "LoanDelete")
                {
                    btnDelete.Visible = true;
                }
            }
        }
    }
}