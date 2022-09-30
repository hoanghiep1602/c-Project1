namespace FrmMain
{
    partial class Frm_DoiMatKhau
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
            this.gbAdmin = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.cboUsers = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbUser = new System.Windows.Forms.GroupBox();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAdmin.SuspendLayout();
            this.gbUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(964, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Password";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbAdmin
            // 
            this.gbAdmin.Controls.Add(this.label5);
            this.gbAdmin.Controls.Add(this.btnResetPassword);
            this.gbAdmin.Controls.Add(this.cboUsers);
            this.gbAdmin.Controls.Add(this.label2);
            this.gbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAdmin.Location = new System.Drawing.Point(12, 120);
            this.gbAdmin.Name = "gbAdmin";
            this.gbAdmin.Size = new System.Drawing.Size(964, 142);
            this.gbAdmin.TabIndex = 1;
            this.gbAdmin.TabStop = false;
            this.gbAdmin.Text = "Admin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select User :";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(696, 58);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(237, 39);
            this.btnResetPassword.TabIndex = 2;
            this.btnResetPassword.Text = "Reset Password";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // cboUsers
            // 
            this.cboUsers.FormattingEnabled = true;
            this.cboUsers.Location = new System.Drawing.Point(226, 58);
            this.cboUsers.Name = "cboUsers";
            this.cboUsers.Size = new System.Drawing.Size(447, 39);
            this.cboUsers.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 32);
            this.label2.TabIndex = 0;
            // 
            // gbUser
            // 
            this.gbUser.Controls.Add(this.btnChangePassword);
            this.gbUser.Controls.Add(this.txtPassword2);
            this.gbUser.Controls.Add(this.txtPassword1);
            this.gbUser.Controls.Add(this.label4);
            this.gbUser.Controls.Add(this.label3);
            this.gbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUser.Location = new System.Drawing.Point(12, 280);
            this.gbUser.Name = "gbUser";
            this.gbUser.Size = new System.Drawing.Size(964, 154);
            this.gbUser.TabIndex = 2;
            this.gbUser.TabStop = false;
            this.gbUser.Text = "User";
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(696, 42);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(237, 88);
            this.btnChangePassword.TabIndex = 3;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(226, 92);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(447, 38);
            this.txtPassword2.TabIndex = 3;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(226, 39);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(447, 38);
            this.txtPassword1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Con_Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // Frm_DoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 467);
            this.Controls.Add(this.gbUser);
            this.Controls.Add(this.gbAdmin);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DoiMatKhau";
            this.Text = "Frm_DoiMatKhau";
            this.Load += new System.EventHandler(this.Frm_DoiMatKhau_Load);
            this.gbAdmin.ResumeLayout(false);
            this.gbAdmin.PerformLayout();
            this.gbUser.ResumeLayout(false);
            this.gbUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAdmin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.ComboBox cboUsers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbUser;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}