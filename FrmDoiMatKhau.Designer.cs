namespace Project01_longphu
{
    partial class FrmDoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.BtnResetPassword = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.gbAdmin.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select User :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Con_Password :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(173, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 35);
            this.textBox1.TabIndex = 4;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword1.Location = new System.Drawing.Point(248, 44);
            this.txtPassword1.Multiline = true;
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(316, 37);
            this.txtPassword1.TabIndex = 5;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(248, 99);
            this.txtPassword2.Multiline = true;
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(316, 37);
            this.txtPassword2.TabIndex = 6;
            // 
            // BtnResetPassword
            // 
            this.BtnResetPassword.Location = new System.Drawing.Point(586, 69);
            this.BtnResetPassword.Name = "BtnResetPassword";
            this.BtnResetPassword.Size = new System.Drawing.Size(208, 40);
            this.BtnResetPassword.TabIndex = 8;
            this.BtnResetPassword.Text = "Reset Password";
            this.BtnResetPassword.UseVisualStyleBackColor = true;
            this.BtnResetPassword.Click += new System.EventHandler(this.BtnResetPassword_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(586, 41);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(208, 95);
            this.btnChangePassword.TabIndex = 9;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.cboUsers);
            this.gbAdmin.Controls.Add(this.richTextBox1);
            this.gbAdmin.Controls.Add(this.label2);
            this.gbAdmin.Controls.Add(this.textBox1);
            this.gbAdmin.Controls.Add(this.BtnResetPassword);
            this.gbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdmin.Location = new System.Drawing.Point(12, 109);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(812, 165);
            this.gbAdmin.TabIndex = 10;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Admin";
            // 
            // cboUsers
            // 
            this.cboUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(248, 72);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(316, 37);
            this.cboUsers.TabIndex = 10;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(107, 60);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(0, 0);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.txtPassword1);
            this.gbUser.Controls.Add(this.txtPassword2);
            this.gbUser.Controls.Add(this.btnChangePassword);
            this.gbUser.Controls.Add(this.label3);
            this.gbUser.Controls.Add(this.label4);
            this.gbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUser.Location = new System.Drawing.Point(12, 280);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(812, 200);
            this.gbUser.TabIndex = 11;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            // 
            // FrmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 495);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.label1);
            this.Name = "FrmDoiMatKhau";
            this.Text = "FrmDoiMatKhau";
            this.Load += new System.EventHandler(this.FrmDoiMatKhau_Load);
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Button BtnResetPassword;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox cboUsers;
    }
}

