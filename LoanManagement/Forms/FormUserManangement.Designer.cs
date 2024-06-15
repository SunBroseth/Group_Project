namespace LoanManagement.Forms
{
    partial class FormUserManangement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.pnPermission = new System.Windows.Forms.Panel();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnApplyPermission = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.LoanDelete = new System.Windows.Forms.CheckBox();
            this.LoanModify = new System.Windows.Forms.CheckBox();
            this.LoanCreate = new System.Windows.Forms.CheckBox();
            this.LoanView = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CollateralDelete = new System.Windows.Forms.CheckBox();
            this.CollateralModify = new System.Windows.Forms.CheckBox();
            this.CollateralCreate = new System.Windows.Forms.CheckBox();
            this.CollateralView = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreditOfficerDelete = new System.Windows.Forms.CheckBox();
            this.CreditOfficerModify = new System.Windows.Forms.CheckBox();
            this.CreditOfficerCreate = new System.Windows.Forms.CheckBox();
            this.CreditOfficerView = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DashboardDelete = new System.Windows.Forms.CheckBox();
            this.DashboardModify = new System.Windows.Forms.CheckBox();
            this.DashboardCreate = new System.Windows.Forms.CheckBox();
            this.DashboardView = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerDelete = new System.Windows.Forms.CheckBox();
            this.CustomerModify = new System.Windows.Forms.CheckBox();
            this.CustomerCreate = new System.Windows.Forms.CheckBox();
            this.CustomerView = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.pnPermission.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(160, 11);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(115, 48);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(297, 11);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 48);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(23, 10);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(115, 48);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nokora", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(482, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Manangement";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1244, 70);
            this.panel3.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 81);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 1);
            this.panel2.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 547);
            this.panel4.TabIndex = 9;
            // 
            // dgUsers
            // 
            this.dgUsers.BackgroundColor = System.Drawing.Color.White;
            this.dgUsers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgUsers.Location = new System.Drawing.Point(5, 151);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.ReadOnly = true;
            this.dgUsers.RowHeadersVisible = false;
            this.dgUsers.RowHeadersWidth = 62;
            this.dgUsers.RowTemplate.Height = 28;
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(256, 547);
            this.dgUsers.TabIndex = 102;
            this.dgUsers.SelectionChanged += new System.EventHandler(this.dgUsers_SelectionChanged);
            // 
            // pnPermission
            // 
            this.pnPermission.BackColor = System.Drawing.Color.White;
            this.pnPermission.Controls.Add(this.btnSelectAll);
            this.pnPermission.Controls.Add(this.btnApplyPermission);
            this.pnPermission.Controls.Add(this.btnClearAll);
            this.pnPermission.Controls.Add(this.LoanDelete);
            this.pnPermission.Controls.Add(this.LoanModify);
            this.pnPermission.Controls.Add(this.LoanCreate);
            this.pnPermission.Controls.Add(this.LoanView);
            this.pnPermission.Controls.Add(this.label6);
            this.pnPermission.Controls.Add(this.CollateralDelete);
            this.pnPermission.Controls.Add(this.CollateralModify);
            this.pnPermission.Controls.Add(this.CollateralCreate);
            this.pnPermission.Controls.Add(this.CollateralView);
            this.pnPermission.Controls.Add(this.label5);
            this.pnPermission.Controls.Add(this.CreditOfficerDelete);
            this.pnPermission.Controls.Add(this.CreditOfficerModify);
            this.pnPermission.Controls.Add(this.CreditOfficerCreate);
            this.pnPermission.Controls.Add(this.CreditOfficerView);
            this.pnPermission.Controls.Add(this.label4);
            this.pnPermission.Controls.Add(this.DashboardDelete);
            this.pnPermission.Controls.Add(this.DashboardModify);
            this.pnPermission.Controls.Add(this.DashboardCreate);
            this.pnPermission.Controls.Add(this.DashboardView);
            this.pnPermission.Controls.Add(this.label3);
            this.pnPermission.Controls.Add(this.CustomerDelete);
            this.pnPermission.Controls.Add(this.CustomerModify);
            this.pnPermission.Controls.Add(this.CustomerCreate);
            this.pnPermission.Controls.Add(this.CustomerView);
            this.pnPermission.Controls.Add(this.label2);
            this.pnPermission.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPermission.Location = new System.Drawing.Point(261, 151);
            this.pnPermission.Name = "pnPermission";
            this.pnPermission.Size = new System.Drawing.Size(983, 547);
            this.pnPermission.TabIndex = 103;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnSelectAll.ForeColor = System.Drawing.Color.White;
            this.btnSelectAll.Location = new System.Drawing.Point(182, 344);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(131, 44);
            this.btnSelectAll.TabIndex = 129;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click_1);
            // 
            // btnApplyPermission
            // 
            this.btnApplyPermission.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnApplyPermission.ForeColor = System.Drawing.Color.White;
            this.btnApplyPermission.Location = new System.Drawing.Point(319, 344);
            this.btnApplyPermission.Name = "btnApplyPermission";
            this.btnApplyPermission.Size = new System.Drawing.Size(219, 44);
            this.btnApplyPermission.TabIndex = 128;
            this.btnApplyPermission.Text = "Apply Permission";
            this.btnApplyPermission.UseVisualStyleBackColor = false;
            this.btnApplyPermission.Click += new System.EventHandler(this.btnApplyPermission_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnClearAll.ForeColor = System.Drawing.Color.White;
            this.btnClearAll.Location = new System.Drawing.Point(45, 343);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(122, 44);
            this.btnClearAll.TabIndex = 127;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // LoanDelete
            // 
            this.LoanDelete.AutoSize = true;
            this.LoanDelete.Location = new System.Drawing.Point(372, 293);
            this.LoanDelete.Name = "LoanDelete";
            this.LoanDelete.Size = new System.Drawing.Size(111, 35);
            this.LoanDelete.TabIndex = 126;
            this.LoanDelete.Text = "Delete";
            this.LoanDelete.UseVisualStyleBackColor = true;
            // 
            // LoanModify
            // 
            this.LoanModify.AutoSize = true;
            this.LoanModify.Location = new System.Drawing.Point(255, 293);
            this.LoanModify.Name = "LoanModify";
            this.LoanModify.Size = new System.Drawing.Size(111, 35);
            this.LoanModify.TabIndex = 125;
            this.LoanModify.Text = "Modify";
            this.LoanModify.UseVisualStyleBackColor = true;
            // 
            // LoanCreate
            // 
            this.LoanCreate.AutoSize = true;
            this.LoanCreate.Location = new System.Drawing.Point(137, 293);
            this.LoanCreate.Name = "LoanCreate";
            this.LoanCreate.Size = new System.Drawing.Size(112, 35);
            this.LoanCreate.TabIndex = 124;
            this.LoanCreate.Text = "Create";
            this.LoanCreate.UseVisualStyleBackColor = true;
            // 
            // LoanView
            // 
            this.LoanView.AutoSize = true;
            this.LoanView.Location = new System.Drawing.Point(38, 293);
            this.LoanView.Name = "LoanView";
            this.LoanView.Size = new System.Drawing.Size(93, 35);
            this.LoanView.TabIndex = 123;
            this.LoanView.Text = "View";
            this.LoanView.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 31);
            this.label6.TabIndex = 122;
            this.label6.Text = "Loan";
            // 
            // CollateralDelete
            // 
            this.CollateralDelete.AutoSize = true;
            this.CollateralDelete.Location = new System.Drawing.Point(372, 231);
            this.CollateralDelete.Name = "CollateralDelete";
            this.CollateralDelete.Size = new System.Drawing.Size(111, 35);
            this.CollateralDelete.TabIndex = 121;
            this.CollateralDelete.Text = "Delete";
            this.CollateralDelete.UseVisualStyleBackColor = true;
            // 
            // CollateralModify
            // 
            this.CollateralModify.AutoSize = true;
            this.CollateralModify.Location = new System.Drawing.Point(255, 231);
            this.CollateralModify.Name = "CollateralModify";
            this.CollateralModify.Size = new System.Drawing.Size(111, 35);
            this.CollateralModify.TabIndex = 120;
            this.CollateralModify.Text = "Modify";
            this.CollateralModify.UseVisualStyleBackColor = true;
            // 
            // CollateralCreate
            // 
            this.CollateralCreate.AutoSize = true;
            this.CollateralCreate.Location = new System.Drawing.Point(137, 231);
            this.CollateralCreate.Name = "CollateralCreate";
            this.CollateralCreate.Size = new System.Drawing.Size(112, 35);
            this.CollateralCreate.TabIndex = 119;
            this.CollateralCreate.Text = "Create";
            this.CollateralCreate.UseVisualStyleBackColor = true;
            // 
            // CollateralView
            // 
            this.CollateralView.AutoSize = true;
            this.CollateralView.Location = new System.Drawing.Point(38, 231);
            this.CollateralView.Name = "CollateralView";
            this.CollateralView.Size = new System.Drawing.Size(93, 35);
            this.CollateralView.TabIndex = 118;
            this.CollateralView.Text = "View";
            this.CollateralView.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 31);
            this.label5.TabIndex = 117;
            this.label5.Text = "Collateral";
            // 
            // CreditOfficerDelete
            // 
            this.CreditOfficerDelete.AutoSize = true;
            this.CreditOfficerDelete.Location = new System.Drawing.Point(372, 169);
            this.CreditOfficerDelete.Name = "CreditOfficerDelete";
            this.CreditOfficerDelete.Size = new System.Drawing.Size(111, 35);
            this.CreditOfficerDelete.TabIndex = 116;
            this.CreditOfficerDelete.Text = "Delete";
            this.CreditOfficerDelete.UseVisualStyleBackColor = true;
            // 
            // CreditOfficerModify
            // 
            this.CreditOfficerModify.AutoSize = true;
            this.CreditOfficerModify.Location = new System.Drawing.Point(255, 169);
            this.CreditOfficerModify.Name = "CreditOfficerModify";
            this.CreditOfficerModify.Size = new System.Drawing.Size(111, 35);
            this.CreditOfficerModify.TabIndex = 115;
            this.CreditOfficerModify.Text = "Modify";
            this.CreditOfficerModify.UseVisualStyleBackColor = true;
            // 
            // CreditOfficerCreate
            // 
            this.CreditOfficerCreate.AutoSize = true;
            this.CreditOfficerCreate.Location = new System.Drawing.Point(137, 169);
            this.CreditOfficerCreate.Name = "CreditOfficerCreate";
            this.CreditOfficerCreate.Size = new System.Drawing.Size(112, 35);
            this.CreditOfficerCreate.TabIndex = 114;
            this.CreditOfficerCreate.Text = "Create";
            this.CreditOfficerCreate.UseVisualStyleBackColor = true;
            // 
            // CreditOfficerView
            // 
            this.CreditOfficerView.AutoSize = true;
            this.CreditOfficerView.Location = new System.Drawing.Point(38, 169);
            this.CreditOfficerView.Name = "CreditOfficerView";
            this.CreditOfficerView.Size = new System.Drawing.Size(93, 35);
            this.CreditOfficerView.TabIndex = 113;
            this.CreditOfficerView.Text = "View";
            this.CreditOfficerView.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 31);
            this.label4.TabIndex = 112;
            this.label4.Text = "Credit Officer";
            // 
            // DashboardDelete
            // 
            this.DashboardDelete.AutoSize = true;
            this.DashboardDelete.Location = new System.Drawing.Point(372, 107);
            this.DashboardDelete.Name = "DashboardDelete";
            this.DashboardDelete.Size = new System.Drawing.Size(111, 35);
            this.DashboardDelete.TabIndex = 111;
            this.DashboardDelete.Text = "Delete";
            this.DashboardDelete.UseVisualStyleBackColor = true;
            // 
            // DashboardModify
            // 
            this.DashboardModify.AutoSize = true;
            this.DashboardModify.Location = new System.Drawing.Point(255, 107);
            this.DashboardModify.Name = "DashboardModify";
            this.DashboardModify.Size = new System.Drawing.Size(111, 35);
            this.DashboardModify.TabIndex = 110;
            this.DashboardModify.Text = "Modify";
            this.DashboardModify.UseVisualStyleBackColor = true;
            // 
            // DashboardCreate
            // 
            this.DashboardCreate.AutoSize = true;
            this.DashboardCreate.Location = new System.Drawing.Point(137, 107);
            this.DashboardCreate.Name = "DashboardCreate";
            this.DashboardCreate.Size = new System.Drawing.Size(112, 35);
            this.DashboardCreate.TabIndex = 109;
            this.DashboardCreate.Text = "Create";
            this.DashboardCreate.UseVisualStyleBackColor = true;
            // 
            // DashboardView
            // 
            this.DashboardView.AutoSize = true;
            this.DashboardView.Location = new System.Drawing.Point(38, 107);
            this.DashboardView.Name = "DashboardView";
            this.DashboardView.Size = new System.Drawing.Size(93, 35);
            this.DashboardView.TabIndex = 108;
            this.DashboardView.Text = "View";
            this.DashboardView.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 31);
            this.label3.TabIndex = 107;
            this.label3.Text = "DashBoard";
            // 
            // CustomerDelete
            // 
            this.CustomerDelete.AutoSize = true;
            this.CustomerDelete.Location = new System.Drawing.Point(372, 45);
            this.CustomerDelete.Name = "CustomerDelete";
            this.CustomerDelete.Size = new System.Drawing.Size(111, 35);
            this.CustomerDelete.TabIndex = 106;
            this.CustomerDelete.Text = "Delete";
            this.CustomerDelete.UseVisualStyleBackColor = true;
            // 
            // CustomerModify
            // 
            this.CustomerModify.AutoSize = true;
            this.CustomerModify.Location = new System.Drawing.Point(255, 45);
            this.CustomerModify.Name = "CustomerModify";
            this.CustomerModify.Size = new System.Drawing.Size(111, 35);
            this.CustomerModify.TabIndex = 105;
            this.CustomerModify.Text = "Modify";
            this.CustomerModify.UseVisualStyleBackColor = true;
            // 
            // CustomerCreate
            // 
            this.CustomerCreate.AutoSize = true;
            this.CustomerCreate.Location = new System.Drawing.Point(137, 45);
            this.CustomerCreate.Name = "CustomerCreate";
            this.CustomerCreate.Size = new System.Drawing.Size(112, 35);
            this.CustomerCreate.TabIndex = 104;
            this.CustomerCreate.Text = "Create";
            this.CustomerCreate.UseVisualStyleBackColor = true;
            // 
            // CustomerView
            // 
            this.CustomerView.AutoSize = true;
            this.CustomerView.Location = new System.Drawing.Point(38, 45);
            this.CustomerView.Name = "CustomerView";
            this.CustomerView.Size = new System.Drawing.Size(93, 35);
            this.CustomerView.TabIndex = 103;
            this.CustomerView.Text = "View";
            this.CustomerView.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 31);
            this.label2.TabIndex = 102;
            this.label2.Text = "Customer Center";
            // 
            // FormUserManangement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 698);
            this.Controls.Add(this.pnPermission);
            this.Controls.Add(this.dgUsers);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormUserManangement";
            this.Text = "FormUserManangement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.pnPermission.ResumeLayout(false);
            this.pnPermission.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Panel pnPermission;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnApplyPermission;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.CheckBox LoanDelete;
        private System.Windows.Forms.CheckBox LoanModify;
        private System.Windows.Forms.CheckBox LoanCreate;
        private System.Windows.Forms.CheckBox LoanView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox CollateralDelete;
        private System.Windows.Forms.CheckBox CollateralModify;
        private System.Windows.Forms.CheckBox CollateralCreate;
        private System.Windows.Forms.CheckBox CollateralView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox CreditOfficerDelete;
        private System.Windows.Forms.CheckBox CreditOfficerModify;
        private System.Windows.Forms.CheckBox CreditOfficerCreate;
        private System.Windows.Forms.CheckBox CreditOfficerView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox DashboardDelete;
        private System.Windows.Forms.CheckBox DashboardModify;
        private System.Windows.Forms.CheckBox DashboardCreate;
        private System.Windows.Forms.CheckBox DashboardView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CustomerDelete;
        private System.Windows.Forms.CheckBox CustomerModify;
        private System.Windows.Forms.CheckBox CustomerCreate;
        private System.Windows.Forms.CheckBox CustomerView;
        private System.Windows.Forms.Label label2;
    }
}