using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMain
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public string ThongTin = string.Empty;

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = "admin";
            txtMatKhau.Text = "admin";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if(!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    if(CheckLogin(txtTaiKhoan.Text, txtMatKhau.Text))
                    {
                        CloseForm = true;
                        ClsMain.taiKhoan = txtTaiKhoan.Text;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtTaiKhoan.ResetText();
                        txtMatKhau.Text = string.Empty;
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mật khẩu\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatKhau.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập tài khoản\n Xin vui lòng kiểm tra lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
            }
        }
        private bool CheckLogin(string taiKhoan, string matKhau)
        {
            return bd.CheckLogin(taiKhoan, matKhau);
        }
        bool CloseForm = false;

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(CloseForm == true)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                CloseForm = true;
                Application.Exit();
            }
        }
        
    }
}
