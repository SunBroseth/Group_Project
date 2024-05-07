namespace LoanManagement.Forms
{
    partial class FormCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPOB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDOB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgAddress = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nokora", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Center";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1244, 1);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnNew);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1244, 70);
            this.panel3.TabIndex = 2;
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
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 151);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 547);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgCustomers);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(5, 151);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(256, 547);
            this.panel5.TabIndex = 4;
            // 
            // dgCustomers
            // 
            this.dgCustomers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.RowHeadersVisible = false;
            this.dgCustomers.RowHeadersWidth = 62;
            this.dgCustomers.RowTemplate.Height = 28;
            this.dgCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCustomers.Size = new System.Drawing.Size(256, 547);
            this.dgCustomers.TabIndex = 5;
            this.dgCustomers.SelectionChanged += new System.EventHandler(this.dgCustomers_SelectionChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgAddress);
            this.panel6.Controls.Add(this.txtAddress);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.txtEmail);
            this.panel6.Controls.Add(this.label7);
            this.panel6.Controls.Add(this.txtPhone);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.txtPOB);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.txtDOB);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Controls.Add(this.txtSex);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txtCustomerName);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(261, 151);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(983, 547);
            this.panel6.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(234, 305);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(272, 99);
            this.txtAddress.TabIndex = 32;
           
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(39, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 31);
            this.label8.TabIndex = 31;
            this.label8.Text = "Address";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(234, 256);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(272, 32);
            this.txtEmail.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(39, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 31);
            this.label7.TabIndex = 29;
            this.label7.Text = "Email";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(234, 208);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(272, 32);
            this.txtPhone.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(39, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 31);
            this.label6.TabIndex = 27;
            this.label6.Text = "Phone";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPOB
            // 
            this.txtPOB.BackColor = System.Drawing.SystemColors.Control;
            this.txtPOB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPOB.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPOB.Location = new System.Drawing.Point(234, 160);
            this.txtPOB.Name = "txtPOB";
            this.txtPOB.ReadOnly = true;
            this.txtPOB.Size = new System.Drawing.Size(272, 32);
            this.txtPOB.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(39, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 31);
            this.label5.TabIndex = 25;
            this.label5.Text = "Place of Birth";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDOB
            // 
            this.txtDOB.BackColor = System.Drawing.SystemColors.Control;
            this.txtDOB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDOB.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDOB.Location = new System.Drawing.Point(234, 113);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.ReadOnly = true;
            this.txtDOB.Size = new System.Drawing.Size(272, 32);
            this.txtDOB.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(39, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 31);
            this.label4.TabIndex = 23;
            this.label4.Text = "Date of Birth";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSex
            // 
            this.txtSex.BackColor = System.Drawing.SystemColors.Control;
            this.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSex.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSex.Location = new System.Drawing.Point(234, 67);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(272, 32);
            this.txtSex.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(39, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Sex";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustomerName.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(234, 24);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(272, 32);
            this.txtCustomerName.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(39, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 28);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dgAddress
            // 
            this.dgAddress.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAddress.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgAddress.Location = new System.Drawing.Point(0, 0);
            this.dgAddress.Name = "dgAddress";
            this.dgAddress.ReadOnly = true;
            this.dgAddress.RowHeadersVisible = false;
            this.dgAddress.RowHeadersWidth = 62;
            this.dgAddress.RowTemplate.Height = 28;
            this.dgAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAddress.Size = new System.Drawing.Size(33, 547);
            this.dgAddress.TabIndex = 33;
            this.dgAddress.Visible = false;
            this.dgAddress.SelectionChanged += new System.EventHandler(this.dgAddress_SelectionChanged);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 698);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPOB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgAddress;
    }
}