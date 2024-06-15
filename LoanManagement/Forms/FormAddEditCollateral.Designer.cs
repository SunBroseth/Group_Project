namespace LoanManagement.Forms
{
    partial class FormAddEditCollateral
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCollateralDecsription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CollateralType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOwnerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCollateralCode = new System.Windows.Forms.TextBox();
            this.txtNationalCardNumber = new System.Windows.Forms.TextBox();
            this.cboCollateralType = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 52);
            this.panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nokora", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(93, 48);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Title";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 52);
            this.panel2.TabIndex = 15;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(726, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 44);
            this.btnCancel.TabIndex = 131;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(589, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(122, 44);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCollateralDecsription
            // 
            this.txtCollateralDecsription.Location = new System.Drawing.Point(488, 264);
            this.txtCollateralDecsription.Multiline = true;
            this.txtCollateralDecsription.Name = "txtCollateralDecsription";
            this.txtCollateralDecsription.Size = new System.Drawing.Size(281, 118);
            this.txtCollateralDecsription.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(245, 31);
            this.label5.TabIndex = 29;
            this.label5.Text = "Collateral Description";
            // 
            // CollateralType
            // 
            this.CollateralType.AutoSize = true;
            this.CollateralType.Location = new System.Drawing.Point(482, 165);
            this.CollateralType.Name = "CollateralType";
            this.CollateralType.Size = new System.Drawing.Size(178, 31);
            this.CollateralType.TabIndex = 27;
            this.CollateralType.Text = "Collateral Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "National Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 31);
            this.label2.TabIndex = 25;
            this.label2.Text = "Collateral Code";
            // 
            // txtOwnerName
            // 
            this.txtOwnerName.Location = new System.Drawing.Point(104, 191);
            this.txtOwnerName.Name = "txtOwnerName";
            this.txtOwnerName.Size = new System.Drawing.Size(281, 39);
            this.txtOwnerName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "Owner Name";
            // 
            // txtCollateralCode
            // 
            this.txtCollateralCode.Location = new System.Drawing.Point(104, 264);
            this.txtCollateralCode.Name = "txtCollateralCode";
            this.txtCollateralCode.Size = new System.Drawing.Size(281, 39);
            this.txtCollateralCode.TabIndex = 35;
            // 
            // txtNationalCardNumber
            // 
            this.txtNationalCardNumber.Location = new System.Drawing.Point(104, 343);
            this.txtNationalCardNumber.Name = "txtNationalCardNumber";
            this.txtNationalCardNumber.Size = new System.Drawing.Size(281, 39);
            this.txtNationalCardNumber.TabIndex = 36;
            // 
            // cboCollateralType
            // 
            this.cboCollateralType.FormattingEnabled = true;
            this.cboCollateralType.Items.AddRange(new object[] {
            "Real Estate",
            "Vehicle",
            "Personal Asset",
            "Cash",
            "Investment",
            "Equity",
            "Equitment"});
            this.cboCollateralType.Location = new System.Drawing.Point(488, 191);
            this.cboCollateralType.Name = "cboCollateralType";
            this.cboCollateralType.Size = new System.Drawing.Size(281, 39);
            this.cboCollateralType.TabIndex = 37;
            // 
            // FormAddEditCollateral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 547);
            this.Controls.Add(this.cboCollateralType);
            this.Controls.Add(this.txtNationalCardNumber);
            this.Controls.Add(this.txtCollateralCode);
            this.Controls.Add(this.txtCollateralDecsription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CollateralType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOwnerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormAddEditCollateral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddEditCollateral";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCollateralDecsription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CollateralType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOwnerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCollateralCode;
        private System.Windows.Forms.TextBox txtNationalCardNumber;
        private System.Windows.Forms.ComboBox cboCollateralType;
    }
}