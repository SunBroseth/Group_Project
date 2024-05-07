namespace LoanManagement
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.pUser = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pLoan = new System.Windows.Forms.Panel();
            this.lblLoan = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pCollateral = new System.Windows.Forms.Panel();
            this.lblCollateral = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pCreditOfficer = new System.Windows.Forms.Panel();
            this.lblCreditOfficer = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pCustomer = new System.Windows.Forms.Panel();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pDashboard = new System.Windows.Forms.Panel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnMain = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pMain.SuspendLayout();
            this.pUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.pCollateral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pCreditOfficer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1244, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nokora", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loan Management System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LoanManagement.Properties.Resources.assets;
            this.pictureBox2.Location = new System.Drawing.Point(12, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pMain.Controls.Add(this.pUser);
            this.pMain.Controls.Add(this.pLoan);
            this.pMain.Controls.Add(this.pCollateral);
            this.pMain.Controls.Add(this.pCreditOfficer);
            this.pMain.Controls.Add(this.pCustomer);
            this.pMain.Controls.Add(this.pDashboard);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMain.Location = new System.Drawing.Point(0, 84);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(247, 567);
            this.pMain.TabIndex = 1;
            // 
            // pUser
            // 
            this.pUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pUser.Controls.Add(this.lblUser);
            this.pUser.Controls.Add(this.pictureBox7);
            this.pUser.Location = new System.Drawing.Point(12, 506);
            this.pUser.Name = "pUser";
            this.pUser.Size = new System.Drawing.Size(219, 46);
            this.pUser.TabIndex = 7;
            this.pUser.MouseEnter += new System.EventHandler(this.pUser_MouseEnter);
            this.pUser.MouseLeave += new System.EventHandler(this.pUser_MouseLeave);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(46, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(211, 31);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User Management";
            this.lblUser.MouseEnter += new System.EventHandler(this.pUser_MouseEnter);
            this.lblUser.MouseLeave += new System.EventHandler(this.pUser_MouseLeave);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::LoanManagement.Properties.Resources.user;
            this.pictureBox7.Location = new System.Drawing.Point(10, 7);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(30, 30);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 2;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.MouseEnter += new System.EventHandler(this.pUser_MouseEnter);
            this.pictureBox7.MouseLeave += new System.EventHandler(this.pUser_MouseLeave);
            // 
            // pLoan
            // 
            this.pLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pLoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pLoan.Controls.Add(this.lblLoan);
            this.pLoan.Controls.Add(this.pictureBox6);
            this.pLoan.Location = new System.Drawing.Point(12, 271);
            this.pLoan.Name = "pLoan";
            this.pLoan.Size = new System.Drawing.Size(219, 46);
            this.pLoan.TabIndex = 6;
            this.pLoan.MouseEnter += new System.EventHandler(this.pLoan_MouseEnter);
            this.pLoan.MouseLeave += new System.EventHandler(this.pLoan_MouseLeave);
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Location = new System.Drawing.Point(46, 11);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(67, 31);
            this.lblLoan.TabIndex = 3;
            this.lblLoan.Text = "Loan";
            this.lblLoan.MouseEnter += new System.EventHandler(this.pLoan_MouseEnter);
            this.lblLoan.MouseLeave += new System.EventHandler(this.pLoan_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::LoanManagement.Properties.Resources.loan;
            this.pictureBox6.Location = new System.Drawing.Point(10, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(30, 30);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.MouseEnter += new System.EventHandler(this.pLoan_MouseEnter);
            this.pictureBox6.MouseLeave += new System.EventHandler(this.pLoan_MouseLeave);
            // 
            // pCollateral
            // 
            this.pCollateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pCollateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCollateral.Controls.Add(this.lblCollateral);
            this.pCollateral.Controls.Add(this.pictureBox5);
            this.pCollateral.Location = new System.Drawing.Point(12, 208);
            this.pCollateral.Name = "pCollateral";
            this.pCollateral.Size = new System.Drawing.Size(219, 46);
            this.pCollateral.TabIndex = 5;
            this.pCollateral.MouseEnter += new System.EventHandler(this.pCollateral_MouseEnter);
            this.pCollateral.MouseLeave += new System.EventHandler(this.pCollateral_MouseLeave);
            // 
            // lblCollateral
            // 
            this.lblCollateral.AutoSize = true;
            this.lblCollateral.Location = new System.Drawing.Point(46, 12);
            this.lblCollateral.Name = "lblCollateral";
            this.lblCollateral.Size = new System.Drawing.Size(117, 31);
            this.lblCollateral.TabIndex = 3;
            this.lblCollateral.Text = "Collateral";
            this.lblCollateral.MouseEnter += new System.EventHandler(this.pCollateral_MouseEnter);
            this.lblCollateral.MouseLeave += new System.EventHandler(this.pCollateral_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LoanManagement.Properties.Resources.collateral;
            this.pictureBox5.Location = new System.Drawing.Point(10, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pCreditOfficer
            // 
            this.pCreditOfficer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pCreditOfficer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCreditOfficer.Controls.Add(this.lblCreditOfficer);
            this.pCreditOfficer.Controls.Add(this.pictureBox4);
            this.pCreditOfficer.Location = new System.Drawing.Point(12, 145);
            this.pCreditOfficer.Name = "pCreditOfficer";
            this.pCreditOfficer.Size = new System.Drawing.Size(219, 46);
            this.pCreditOfficer.TabIndex = 4;
            this.pCreditOfficer.MouseEnter += new System.EventHandler(this.pCreditOfficer_MouseEnter);
            this.pCreditOfficer.MouseLeave += new System.EventHandler(this.pCreditOfficer_MouseLeave);
            // 
            // lblCreditOfficer
            // 
            this.lblCreditOfficer.AutoSize = true;
            this.lblCreditOfficer.Location = new System.Drawing.Point(46, 12);
            this.lblCreditOfficer.Name = "lblCreditOfficer";
            this.lblCreditOfficer.Size = new System.Drawing.Size(156, 31);
            this.lblCreditOfficer.TabIndex = 3;
            this.lblCreditOfficer.Text = "Credit Officer";
            this.lblCreditOfficer.MouseEnter += new System.EventHandler(this.pCreditOfficer_MouseEnter);
            this.lblCreditOfficer.MouseLeave += new System.EventHandler(this.pCreditOfficer_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LoanManagement.Properties.Resources.personal;
            this.pictureBox4.Location = new System.Drawing.Point(10, 7);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pCreditOfficer_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pCreditOfficer_MouseLeave);
            // 
            // pCustomer
            // 
            this.pCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCustomer.Controls.Add(this.lblCustomer);
            this.pCustomer.Controls.Add(this.pictureBox3);
            this.pCustomer.Location = new System.Drawing.Point(12, 82);
            this.pCustomer.Name = "pCustomer";
            this.pCustomer.Size = new System.Drawing.Size(219, 46);
            this.pCustomer.TabIndex = 3;
            this.pCustomer.Click += new System.EventHandler(this.pCustomer_Click);
            this.pCustomer.MouseEnter += new System.EventHandler(this.pCustomer_MouseEnter);
            this.pCustomer.MouseLeave += new System.EventHandler(this.pCustomer_MouseLeave);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(46, 12);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(196, 31);
            this.lblCustomer.TabIndex = 3;
            this.lblCustomer.Text = "Customer Center";
            this.lblCustomer.Click += new System.EventHandler(this.pCustomer_Click);
            this.lblCustomer.MouseEnter += new System.EventHandler(this.pCustomer_MouseEnter);
            this.lblCustomer.MouseLeave += new System.EventHandler(this.pCustomer_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LoanManagement.Properties.Resources.customer;
            this.pictureBox3.Location = new System.Drawing.Point(10, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pCustomer_Click);
            this.pictureBox3.MouseEnter += new System.EventHandler(this.pCustomer_MouseEnter);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pCustomer_MouseLeave);
            // 
            // pDashboard
            // 
            this.pDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.pDashboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDashboard.Controls.Add(this.lblDashboard);
            this.pDashboard.Controls.Add(this.PictureBox1);
            this.pDashboard.Location = new System.Drawing.Point(12, 19);
            this.pDashboard.Name = "pDashboard";
            this.pDashboard.Size = new System.Drawing.Size(219, 46);
            this.pDashboard.TabIndex = 2;
            this.pDashboard.MouseEnter += new System.EventHandler(this.pDashboard_MouseEnter);
            this.pDashboard.MouseLeave += new System.EventHandler(this.pDashboard_MouseLeave);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(46, 12);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(132, 31);
            this.lblDashboard.TabIndex = 2;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.MouseEnter += new System.EventHandler(this.pDashboard_MouseEnter);
            this.lblDashboard.MouseLeave += new System.EventHandler(this.pDashboard_MouseLeave);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = global::LoanManagement.Properties.Resources.dashboard;
            this.PictureBox1.Location = new System.Drawing.Point(10, 7);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(30, 30);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.MouseEnter += new System.EventHandler(this.pDashboard_MouseEnter);
            this.PictureBox1.MouseLeave += new System.EventHandler(this.pDashboard_MouseLeave);
            // 
            // pnMain
            // 
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(247, 84);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(997, 567);
            this.pnMain.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 651);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Nokora", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pMain.ResumeLayout(false);
            this.pUser.ResumeLayout(false);
            this.pUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pLoan.ResumeLayout(false);
            this.pLoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.pCollateral.ResumeLayout(false);
            this.pCollateral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pCreditOfficer.ResumeLayout(false);
            this.pCreditOfficer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pCustomer.ResumeLayout(false);
            this.pCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pDashboard.ResumeLayout(false);
            this.pDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel pDashboard;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pCollateral;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel pCreditOfficer;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pCustomer;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pLoan;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Panel pUser;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblCollateral;
        private System.Windows.Forms.Label lblCreditOfficer;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnMain;
    }
}

