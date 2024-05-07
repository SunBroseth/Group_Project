namespace LoanManagement.Forms
{
    partial class FormCustomerAddEdit
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPOB = new System.Windows.Forms.TextBox();
            this.cboSex = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.DateTimePicker();
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
            this.panel1.Size = new System.Drawing.Size(866, 60);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Nokora", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(21, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(127, 64);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 487);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 60);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(629, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 45);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(752, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 45);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(53, 134);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(305, 39);
            this.txtCustomerName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(479, 134);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(305, 39);
            this.txtPhone.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(479, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 39);
            this.txtEmail.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(479, 296);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(305, 124);
            this.txtAddress.TabIndex = 12;
            this.txtAddress.Text = "Unkown";
            // 
            // txtPOB
            // 
            this.txtPOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPOB.Location = new System.Drawing.Point(53, 381);
            this.txtPOB.Name = "txtPOB";
            this.txtPOB.Size = new System.Drawing.Size(305, 39);
            this.txtPOB.TabIndex = 14;
            // 
            // cboSex
            // 
            this.cboSex.FormattingEnabled = true;
            this.cboSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Rather not say"});
            this.cboSex.Location = new System.Drawing.Point(53, 214);
            this.cboSex.Name = "cboSex";
            this.cboSex.Size = new System.Drawing.Size(225, 39);
            this.cboSex.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(473, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Sex";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(473, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(47, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Date of Birth";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(473, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(47, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 25);
            this.label7.TabIndex = 22;
            this.label7.Text = "Place of Birth";
            // 
            // DOB
            // 
            this.DOB.Location = new System.Drawing.Point(53, 295);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(305, 39);
            this.DOB.TabIndex = 23;
            // 
            // FormCustomerAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 547);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboSex);
            this.Controls.Add(this.txtPOB);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCustomerAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCustomer";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPOB;
        private System.Windows.Forms.ComboBox cboSex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker DOB;
        private System.Windows.Forms.Label lblTitle;
    }
}