namespace WindowsForms
{
    partial class Form1
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
            this.lblAccessProvider = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAccessDatabasePassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtAccessSystemDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccessPassword = new System.Windows.Forms.TextBox();
            this.txtAccessUserID = new System.Windows.Forms.TextBox();
            this.lblAccessPassword = new System.Windows.Forms.Label();
            this.lblAccessUserID = new System.Windows.Forms.Label();
            this.lblAccessDBname = new System.Windows.Forms.Label();
            this.btnAccessTest = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAccessDBname = new System.Windows.Forms.TextBox();
            this.btnAccessOK = new System.Windows.Forms.Button();
            this.txtAccessProvider = new System.Windows.Forms.TextBox();
            this.gbxAccess3 = new System.Windows.Forms.GroupBox();
            this.gbxAccess2 = new System.Windows.Forms.GroupBox();
            this.gbxAccess1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMysqlDatabase = new System.Windows.Forms.TextBox();
            this.txtMysqlPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMysqlUserID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMysqlPort = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMysqlHost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxAccess3.SuspendLayout();
            this.gbxAccess2.SuspendLayout();
            this.gbxAccess1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccessProvider
            // 
            this.lblAccessProvider.Location = new System.Drawing.Point(24, 24);
            this.lblAccessProvider.Name = "lblAccessProvider";
            this.lblAccessProvider.Size = new System.Drawing.Size(96, 16);
            this.lblAccessProvider.TabIndex = 4;
            this.lblAccessProvider.Text = "Provider Name: ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtAccessDatabasePassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtAccessSystemDB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(354, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 80);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Security";
            // 
            // txtAccessDatabasePassword
            // 
            this.txtAccessDatabasePassword.Location = new System.Drawing.Point(96, 43);
            this.txtAccessDatabasePassword.Name = "txtAccessDatabasePassword";
            this.txtAccessDatabasePassword.PasswordChar = '*';
            this.txtAccessDatabasePassword.Size = new System.Drawing.Size(218, 20);
            this.txtAccessDatabasePassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(24, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAccessSystemDB
            // 
            this.txtAccessSystemDB.Location = new System.Drawing.Point(96, 13);
            this.txtAccessSystemDB.Name = "txtAccessSystemDB";
            this.txtAccessSystemDB.Size = new System.Drawing.Size(154, 20);
            this.txtAccessSystemDB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "System DB :";
            // 
            // txtAccessPassword
            // 
            this.txtAccessPassword.Location = new System.Drawing.Point(88, 54);
            this.txtAccessPassword.Name = "txtAccessPassword";
            this.txtAccessPassword.PasswordChar = '*';
            this.txtAccessPassword.Size = new System.Drawing.Size(200, 20);
            this.txtAccessPassword.TabIndex = 3;
            // 
            // txtAccessUserID
            // 
            this.txtAccessUserID.Location = new System.Drawing.Point(88, 22);
            this.txtAccessUserID.Name = "txtAccessUserID";
            this.txtAccessUserID.Size = new System.Drawing.Size(200, 20);
            this.txtAccessUserID.TabIndex = 2;
            // 
            // lblAccessPassword
            // 
            this.lblAccessPassword.Location = new System.Drawing.Point(16, 51);
            this.lblAccessPassword.Name = "lblAccessPassword";
            this.lblAccessPassword.Size = new System.Drawing.Size(64, 23);
            this.lblAccessPassword.TabIndex = 1;
            this.lblAccessPassword.Text = "Password:";
            this.lblAccessPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccessUserID
            // 
            this.lblAccessUserID.Location = new System.Drawing.Point(16, 22);
            this.lblAccessUserID.Name = "lblAccessUserID";
            this.lblAccessUserID.Size = new System.Drawing.Size(64, 23);
            this.lblAccessUserID.TabIndex = 0;
            this.lblAccessUserID.Text = "User ID:";
            this.lblAccessUserID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAccessDBname
            // 
            this.lblAccessDBname.Location = new System.Drawing.Point(24, 24);
            this.lblAccessDBname.Name = "lblAccessDBname";
            this.lblAccessDBname.Size = new System.Drawing.Size(104, 16);
            this.lblAccessDBname.TabIndex = 0;
            this.lblAccessDBname.Text = "Database Name: ";
            // 
            // btnAccessTest
            // 
            this.btnAccessTest.BackColor = System.Drawing.Color.Transparent;
            this.btnAccessTest.Location = new System.Drawing.Point(273, 444);
            this.btnAccessTest.Name = "btnAccessTest";
            this.btnAccessTest.Size = new System.Drawing.Size(75, 23);
            this.btnAccessTest.TabIndex = 36;
            this.btnAccessTest.Text = "Test";
            this.btnAccessTest.UseVisualStyleBackColor = false;
            this.btnAccessTest.Click += new System.EventHandler(this.btnAccessTest_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(256, 40);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(64, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAccessDBname
            // 
            this.txtAccessDBname.Location = new System.Drawing.Point(40, 40);
            this.txtAccessDBname.Name = "txtAccessDBname";
            this.txtAccessDBname.Size = new System.Drawing.Size(208, 20);
            this.txtAccessDBname.TabIndex = 3;
            // 
            // btnAccessOK
            // 
            this.btnAccessOK.BackColor = System.Drawing.Color.Transparent;
            this.btnAccessOK.Location = new System.Drawing.Point(381, 444);
            this.btnAccessOK.Name = "btnAccessOK";
            this.btnAccessOK.Size = new System.Drawing.Size(75, 23);
            this.btnAccessOK.TabIndex = 35;
            this.btnAccessOK.Text = "OK";
            this.btnAccessOK.UseVisualStyleBackColor = false;
            // 
            // txtAccessProvider
            // 
            this.txtAccessProvider.Location = new System.Drawing.Point(40, 48);
            this.txtAccessProvider.Name = "txtAccessProvider";
            this.txtAccessProvider.Size = new System.Drawing.Size(256, 20);
            this.txtAccessProvider.TabIndex = 6;
            this.txtAccessProvider.Text = "Microsoft.Jet.OLEDB.4.0";
            // 
            // gbxAccess3
            // 
            this.gbxAccess3.BackColor = System.Drawing.Color.Transparent;
            this.gbxAccess3.Controls.Add(this.txtAccessPassword);
            this.gbxAccess3.Controls.Add(this.txtAccessUserID);
            this.gbxAccess3.Controls.Add(this.lblAccessPassword);
            this.gbxAccess3.Controls.Add(this.lblAccessUserID);
            this.gbxAccess3.Location = new System.Drawing.Point(354, 10);
            this.gbxAccess3.Name = "gbxAccess3";
            this.gbxAccess3.Size = new System.Drawing.Size(320, 82);
            this.gbxAccess3.TabIndex = 34;
            this.gbxAccess3.TabStop = false;
            this.gbxAccess3.Text = "User Credentials";
            // 
            // gbxAccess2
            // 
            this.gbxAccess2.BackColor = System.Drawing.Color.Transparent;
            this.gbxAccess2.Controls.Add(this.btnBrowse);
            this.gbxAccess2.Controls.Add(this.txtAccessDBname);
            this.gbxAccess2.Controls.Add(this.lblAccessDBname);
            this.gbxAccess2.Location = new System.Drawing.Point(12, 98);
            this.gbxAccess2.Name = "gbxAccess2";
            this.gbxAccess2.Size = new System.Drawing.Size(336, 80);
            this.gbxAccess2.TabIndex = 32;
            this.gbxAccess2.TabStop = false;
            this.gbxAccess2.Text = "Database";
            // 
            // gbxAccess1
            // 
            this.gbxAccess1.BackColor = System.Drawing.Color.Transparent;
            this.gbxAccess1.Controls.Add(this.txtAccessProvider);
            this.gbxAccess1.Controls.Add(this.lblAccessProvider);
            this.gbxAccess1.Location = new System.Drawing.Point(12, 12);
            this.gbxAccess1.Name = "gbxAccess1";
            this.gbxAccess1.Size = new System.Drawing.Size(336, 80);
            this.gbxAccess1.TabIndex = 31;
            this.gbxAccess1.TabStop = false;
            this.gbxAccess1.Text = "Access Data Provider";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMysqlDatabase);
            this.groupBox2.Controls.Add(this.txtMysqlPassword);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMysqlUserID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtMysqlPort);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMysqlHost);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 210);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mysql Connection Options";
            // 
            // txtMysqlDatabase
            // 
            this.txtMysqlDatabase.Location = new System.Drawing.Point(40, 170);
            this.txtMysqlDatabase.Name = "txtMysqlDatabase";
            this.txtMysqlDatabase.Size = new System.Drawing.Size(256, 20);
            this.txtMysqlDatabase.TabIndex = 6;
            // 
            // txtMysqlPassword
            // 
            this.txtMysqlPassword.Location = new System.Drawing.Point(357, 107);
            this.txtMysqlPassword.Name = "txtMysqlPassword";
            this.txtMysqlPassword.Size = new System.Drawing.Size(256, 20);
            this.txtMysqlPassword.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(24, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "Destination Dtabase:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(341, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // txtMysqlUserID
            // 
            this.txtMysqlUserID.Location = new System.Drawing.Point(357, 48);
            this.txtMysqlUserID.Name = "txtMysqlUserID";
            this.txtMysqlUserID.Size = new System.Drawing.Size(256, 20);
            this.txtMysqlUserID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(341, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Username:";
            // 
            // txtMysqlPort
            // 
            this.txtMysqlPort.Location = new System.Drawing.Point(40, 107);
            this.txtMysqlPort.Name = "txtMysqlPort";
            this.txtMysqlPort.Size = new System.Drawing.Size(256, 20);
            this.txtMysqlPort.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(24, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "port ";
            // 
            // txtMysqlHost
            // 
            this.txtMysqlHost.Location = new System.Drawing.Point(40, 48);
            this.txtMysqlHost.Name = "txtMysqlHost";
            this.txtMysqlHost.Size = new System.Drawing.Size(256, 20);
            this.txtMysqlHost.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(24, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Host:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAccessTest);
            this.Controls.Add(this.btnAccessOK);
            this.Controls.Add(this.gbxAccess3);
            this.Controls.Add(this.gbxAccess2);
            this.Controls.Add(this.gbxAccess1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxAccess3.ResumeLayout(false);
            this.gbxAccess3.PerformLayout();
            this.gbxAccess2.ResumeLayout(false);
            this.gbxAccess2.PerformLayout();
            this.gbxAccess1.ResumeLayout(false);
            this.gbxAccess1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label lblAccessProvider;
        internal System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox txtAccessDatabasePassword;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.TextBox txtAccessSystemDB;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtAccessPassword;
        internal System.Windows.Forms.TextBox txtAccessUserID;
        internal System.Windows.Forms.Label lblAccessPassword;
        internal System.Windows.Forms.Label lblAccessUserID;
        internal System.Windows.Forms.Label lblAccessDBname;
        internal System.Windows.Forms.Button btnAccessTest;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.TextBox txtAccessDBname;
        internal System.Windows.Forms.Button btnAccessOK;
        internal System.Windows.Forms.TextBox txtAccessProvider;
        internal System.Windows.Forms.GroupBox gbxAccess3;
        internal System.Windows.Forms.GroupBox gbxAccess2;
        internal System.Windows.Forms.GroupBox gbxAccess1;
        internal System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.TextBox txtMysqlDatabase;
        internal System.Windows.Forms.TextBox txtMysqlPassword;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtMysqlUserID;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.TextBox txtMysqlPort;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.TextBox txtMysqlHost;
        internal System.Windows.Forms.Label label6;
    }
}

