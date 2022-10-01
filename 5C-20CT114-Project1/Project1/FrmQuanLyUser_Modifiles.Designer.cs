namespace Project1
{
    partial class FrmQuanLyUser_Modifiles
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
            this.txtId = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.Label();
            this.chkMatKhau = new System.Windows.Forms.CheckBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.AutoSize = true;
            this.txtId.Location = new System.Drawing.Point(176, 94);
            this.txtId.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtId.Name = "txtId";
            this.txtId.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtId.Size = new System.Drawing.Size(44, 36);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "ID";
            this.txtId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtId.Click += new System.EventHandler(this.txtId_Click);
            // 
            // textID
            // 
            this.textID.Enabled = false;
            this.textID.Location = new System.Drawing.Point(243, 89);
            this.textID.Margin = new System.Windows.Forms.Padding(7);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(547, 41);
            this.textID.TabIndex = 1;
            // 
            // textUserName
            // 
            this.textUserName.Location = new System.Drawing.Point(243, 157);
            this.textUserName.Margin = new System.Windows.Forms.Padding(7);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(547, 41);
            this.textUserName.TabIndex = 3;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.AutoSize = true;
            this.txtTaiKhoan.Location = new System.Drawing.Point(69, 163);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTaiKhoan.Size = new System.Drawing.Size(151, 36);
            this.txtTaiKhoan.TabIndex = 2;
            this.txtTaiKhoan.Text = "Tài Khoản";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(243, 231);
            this.textPassword.Margin = new System.Windows.Forms.Padding(7);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(547, 41);
            this.textPassword.TabIndex = 5;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoSize = true;
            this.txtMatKhau.Location = new System.Drawing.Point(79, 237);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMatKhau.Size = new System.Drawing.Size(142, 36);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.Text = "Mật Khẩu";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(243, 306);
            this.textName.Margin = new System.Windows.Forms.Padding(7);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(547, 41);
            this.textName.TabIndex = 7;
            // 
            // txtHoTen
            // 
            this.txtHoTen.AutoSize = true;
            this.txtHoTen.Location = new System.Drawing.Point(65, 312);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtHoTen.Size = new System.Drawing.Size(157, 36);
            this.txtHoTen.TabIndex = 6;
            this.txtHoTen.Text = "Họ Và Tên";
            // 
            // chkMatKhau
            // 
            this.chkMatKhau.AutoSize = true;
            this.chkMatKhau.Location = new System.Drawing.Point(243, 376);
            this.chkMatKhau.Margin = new System.Windows.Forms.Padding(7);
            this.chkMatKhau.Name = "chkMatKhau";
            this.chkMatKhau.Size = new System.Drawing.Size(228, 40);
            this.chkMatKhau.TabIndex = 8;
            this.chkMatKhau.Text = "Nhớ Mật Khẩu";
            this.chkMatKhau.UseVisualStyleBackColor = true;
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.ForestGreen;
            this.applyButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.applyButton.Location = new System.Drawing.Point(243, 429);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(266, 61);
            this.applyButton.TabIndex = 9;
            this.applyButton.Text = "Xác Nhận";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(524, 429);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(266, 61);
            this.button2.TabIndex = 9;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // titleText
            // 
            this.titleText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.ForeColor = System.Drawing.Color.Black;
            this.titleText.Location = new System.Drawing.Point(12, 9);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(851, 51);
            this.titleText.TabIndex = 10;
            this.titleText.Text = "Sửa Thông Tin";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmQuanLyUser_Modifiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 570);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.chkMatKhau);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "FrmQuanLyUser_Modifiles";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "FrmQuanLyUser_Modifies";
            this.Load += new System.EventHandler(this.FrmQuanLyUser_Modifiles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
 
        

        private System.Windows.Forms.Label txtId;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label txtTaiKhoan;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label txtMatKhau;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label txtHoTen;
        private System.Windows.Forms.CheckBox chkMatKhau;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label titleText;
    }
    }
