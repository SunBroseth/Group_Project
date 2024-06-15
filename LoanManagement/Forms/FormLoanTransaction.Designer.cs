namespace LoanManagement.Forms
{
    partial class FormLoanTransaction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnBackward = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLoanId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLoanCode = new System.Windows.Forms.TextBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.txtPaymentFrequencyCode = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtLoanDate = new System.Windows.Forms.DateTimePicker();
            this.cboCreditOfficer = new System.Windows.Forms.ComboBox();
            this.cboCollateral = new System.Windows.Forms.ComboBox();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CollateralType = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgLoanDetail = new System.Windows.Forms.DataGridView();
            this.LoanDetailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BeginningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Principle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndingBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPaid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PaidDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.epCustomer = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnForward);
            this.panel1.Controls.Add(this.btnBackward);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 80);
            this.panel1.TabIndex = 4;
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnForward.Font = new System.Drawing.Font("Nokora", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Location = new System.Drawing.Point(435, 21);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(59, 48);
            this.btnForward.TabIndex = 57;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = false;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnBackward
            // 
            this.btnBackward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnBackward.Font = new System.Drawing.Font("Nokora", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackward.ForeColor = System.Drawing.Color.White;
            this.btnBackward.Location = new System.Drawing.Point(379, 20);
            this.btnBackward.Name = "btnBackward";
            this.btnBackward.Size = new System.Drawing.Size(59, 48);
            this.btnBackward.TabIndex = 56;
            this.btnBackward.Text = "<";
            this.btnBackward.UseVisualStyleBackColor = false;
            this.btnBackward.Click += new System.EventHandler(this.btnBackward_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nokora", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loan Transaction";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(729, 21);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 48);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(613, 21);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 48);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(502, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(110, 48);
            this.btnNew.TabIndex = 52;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Visible = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnCancel.Enabled = false;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(937, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 48);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnSave.Enabled = false;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(842, 20);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 48);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1244, 1);
            this.panel5.TabIndex = 52;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 617);
            this.panel3.TabIndex = 53;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1234, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 617);
            this.panel4.TabIndex = 54;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtLoanId);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtLoanCode);
            this.panel2.Controls.Add(this.cboCustomer);
            this.panel2.Controls.Add(this.txtPaymentFrequencyCode);
            this.panel2.Controls.Add(this.txtMemo);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtInterestRate);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dtLoanDate);
            this.panel2.Controls.Add(this.cboCreditOfficer);
            this.panel2.Controls.Add(this.cboCollateral);
            this.panel2.Controls.Add(this.txtLoanAmount);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtCurrency);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.CollateralType);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 277);
            this.panel2.TabIndex = 55;
            // 
            // txtLoanId
            // 
            this.txtLoanId.Location = new System.Drawing.Point(6, 30);
            this.txtLoanId.Name = "txtLoanId";
            this.txtLoanId.ReadOnly = true;
            this.txtLoanId.Size = new System.Drawing.Size(40, 39);
            this.txtLoanId.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 31);
            this.label11.TabIndex = 68;
            this.label11.Text = "Id";
            // 
            // txtLoanCode
            // 
            this.txtLoanCode.Location = new System.Drawing.Point(370, 31);
            this.txtLoanCode.Name = "txtLoanCode";
            this.txtLoanCode.ReadOnly = true;
            this.txtLoanCode.Size = new System.Drawing.Size(281, 39);
            this.txtLoanCode.TabIndex = 67;
            // 
            // cboCustomer
            // 
            this.cboCustomer.Enabled = false;
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(58, 31);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(281, 39);
            this.cboCustomer.TabIndex = 66;
            // 
            // txtPaymentFrequencyCode
            // 
            this.txtPaymentFrequencyCode.Location = new System.Drawing.Point(683, 31);
            this.txtPaymentFrequencyCode.Name = "txtPaymentFrequencyCode";
            this.txtPaymentFrequencyCode.ReadOnly = true;
            this.txtPaymentFrequencyCode.Size = new System.Drawing.Size(281, 39);
            this.txtPaymentFrequencyCode.TabIndex = 65;
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(683, 98);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.ReadOnly = true;
            this.txtMemo.Size = new System.Drawing.Size(281, 165);
            this.txtMemo.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(677, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 31);
            this.label9.TabIndex = 63;
            this.label9.Text = "Memo";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(677, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(292, 31);
            this.label10.TabIndex = 61;
            this.label10.Text = "Payment Frequency Code";
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.Location = new System.Drawing.Point(370, 232);
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.ReadOnly = true;
            this.txtInterestRate.Size = new System.Drawing.Size(281, 39);
            this.txtInterestRate.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 31);
            this.label8.TabIndex = 59;
            this.label8.Text = "Interest Rate";
            // 
            // dtLoanDate
            // 
            this.dtLoanDate.Enabled = false;
            this.dtLoanDate.Location = new System.Drawing.Point(58, 232);
            this.dtLoanDate.Name = "dtLoanDate";
            this.dtLoanDate.Size = new System.Drawing.Size(281, 39);
            this.dtLoanDate.TabIndex = 58;
            // 
            // cboCreditOfficer
            // 
            this.cboCreditOfficer.Enabled = false;
            this.cboCreditOfficer.FormattingEnabled = true;
            this.cboCreditOfficer.Items.AddRange(new object[] {
            "Real Estate",
            "Vehicle",
            "Personal Asset",
            "Cash",
            "Investment",
            "Equity",
            "Equitment"});
            this.cboCreditOfficer.Location = new System.Drawing.Point(58, 164);
            this.cboCreditOfficer.Name = "cboCreditOfficer";
            this.cboCreditOfficer.Size = new System.Drawing.Size(281, 39);
            this.cboCreditOfficer.TabIndex = 57;
            // 
            // cboCollateral
            // 
            this.cboCollateral.Enabled = false;
            this.cboCollateral.FormattingEnabled = true;
            this.cboCollateral.Location = new System.Drawing.Point(58, 97);
            this.cboCollateral.Name = "cboCollateral";
            this.cboCollateral.Size = new System.Drawing.Size(281, 39);
            this.cboCollateral.TabIndex = 56;
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(370, 98);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.ReadOnly = true;
            this.txtLoanAmount.Size = new System.Drawing.Size(281, 39);
            this.txtLoanAmount.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 31);
            this.label7.TabIndex = 50;
            this.label7.Text = "Loan Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 31);
            this.label6.TabIndex = 48;
            this.label6.Text = "Loan Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 31);
            this.label4.TabIndex = 38;
            this.label4.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 31);
            this.label2.TabIndex = 40;
            this.label2.Text = "Collateral";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(370, 166);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.ReadOnly = true;
            this.txtCurrency.Size = new System.Drawing.Size(281, 39);
            this.txtCurrency.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 31);
            this.label3.TabIndex = 41;
            this.label3.Text = "Credit Officer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 43;
            this.label5.Text = "Currency";
            // 
            // CollateralType
            // 
            this.CollateralType.AutoSize = true;
            this.CollateralType.Location = new System.Drawing.Point(364, 5);
            this.CollateralType.Name = "CollateralType";
            this.CollateralType.Size = new System.Drawing.Size(132, 31);
            this.CollateralType.TabIndex = 42;
            this.CollateralType.Text = "Loan Code";
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(10, 358);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1224, 13);
            this.panel6.TabIndex = 56;
            // 
            // dgLoanDetail
            // 
            this.dgLoanDetail.AllowUserToResizeColumns = false;
            this.dgLoanDetail.AllowUserToResizeRows = false;
            this.dgLoanDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgLoanDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgLoanDetail.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgLoanDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgLoanDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLoanDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoanDetailId,
            this.LoanId,
            this.PeriodNo,
            this.BeginningBalance,
            this.Principle,
            this.Interest,
            this.Payment,
            this.EndingBalance,
            this.IsPaid,
            this.PaidDate,
            this.Note});
            this.dgLoanDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgLoanDetail.Enabled = false;
            this.dgLoanDetail.Location = new System.Drawing.Point(10, 371);
            this.dgLoanDetail.Name = "dgLoanDetail";
            this.dgLoanDetail.RowHeadersVisible = false;
            this.dgLoanDetail.RowHeadersWidth = 62;
            this.dgLoanDetail.RowTemplate.Height = 28;
            this.dgLoanDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgLoanDetail.Size = new System.Drawing.Size(1224, 327);
            this.dgLoanDetail.TabIndex = 57;
            this.dgLoanDetail.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgLoanDetail_DefaultValuesNeeded);
            // 
            // LoanDetailId
            // 
            this.LoanDetailId.HeaderText = "LoanDetailId";
            this.LoanDetailId.MinimumWidth = 8;
            this.LoanDetailId.Name = "LoanDetailId";
            this.LoanDetailId.Visible = false;
            // 
            // LoanId
            // 
            this.LoanId.HeaderText = "LoanId";
            this.LoanId.MinimumWidth = 8;
            this.LoanId.Name = "LoanId";
            this.LoanId.Visible = false;
            // 
            // PeriodNo
            // 
            this.PeriodNo.HeaderText = "P.No";
            this.PeriodNo.MinimumWidth = 8;
            this.PeriodNo.Name = "PeriodNo";
            // 
            // BeginningBalance
            // 
            this.BeginningBalance.HeaderText = "BegBal";
            this.BeginningBalance.MinimumWidth = 8;
            this.BeginningBalance.Name = "BeginningBalance";
            // 
            // Principle
            // 
            this.Principle.HeaderText = "Principle";
            this.Principle.MinimumWidth = 8;
            this.Principle.Name = "Principle";
            // 
            // Interest
            // 
            this.Interest.HeaderText = "Interest";
            this.Interest.MinimumWidth = 8;
            this.Interest.Name = "Interest";
            // 
            // Payment
            // 
            this.Payment.HeaderText = "Payment";
            this.Payment.MinimumWidth = 8;
            this.Payment.Name = "Payment";
            // 
            // EndingBalance
            // 
            this.EndingBalance.HeaderText = "EndBal";
            this.EndingBalance.MinimumWidth = 8;
            this.EndingBalance.Name = "EndingBalance";
            // 
            // IsPaid
            // 
            this.IsPaid.FalseValue = "0";
            this.IsPaid.HeaderText = "IsPaid";
            this.IsPaid.MinimumWidth = 8;
            this.IsPaid.Name = "IsPaid";
            this.IsPaid.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.IsPaid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.IsPaid.TrueValue = "1";
            // 
            // PaidDate
            // 
            this.PaidDate.HeaderText = "PaidDate";
            this.PaidDate.MinimumWidth = 8;
            this.PaidDate.Name = "PaidDate";
            // 
            // Note
            // 
            this.Note.HeaderText = "Note";
            this.Note.MinimumWidth = 8;
            this.Note.Name = "Note";
            // 
            // epCustomer
            // 
            this.epCustomer.ContainerControl = this;
            // 
            // FormLoanTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 698);
            this.Controls.Add(this.dgLoanDetail);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLoanTransaction";
            this.Text = "FormLoanTransaction";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLoanTransaction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgLoanDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CollateralType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgLoanDetail;
        private System.Windows.Forms.ComboBox cboCollateral;
        private System.Windows.Forms.DateTimePicker dtLoanDate;
        private System.Windows.Forms.ComboBox cboCreditOfficer;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPaymentFrequencyCode;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TextBox txtLoanCode;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnBackward;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider epCustomer;
        private System.Windows.Forms.TextBox txtLoanId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanDetailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BeginningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Principle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interest;
        private System.Windows.Forms.DataGridViewTextBoxColumn Payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndingBalance;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsPaid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaidDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
    }
}