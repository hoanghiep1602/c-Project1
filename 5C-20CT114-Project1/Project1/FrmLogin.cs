using Project1.BusinessLayer;
using Project1.Data_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class FrmLogin : Form
    {
        private BLLUser bllUser;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            bllUser = new BLLUser(FrmMain.Instance.userDataPath);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //this.Close();//dong 1 form
            trangThaiDongForm = true;
            Application.Exit();//dong ca chuong trinh
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
            {
                if (!string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    User user = KiemTraDangNhap(txtTaiKhoan.Text, txtMatKhau.Text);
                    if (user != null)
                    {
                        trangThaiDongForm = true;
                        FrmMain.Instance.SetUserInfo(user);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("tai khoan hoac mat khau ko dung", "Thong Bao", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        txtTaiKhoan.ResetText();
                        txtMatKhau.ResetText();
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tai khoan rong", "Waring", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    txtTaiKhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mat Khau rong", "Waring", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtMatKhau.Focus();
            }
        }
        /// <summary>
        /// phuong thuc kiem tra dang nham
        /// </summary>
        /// <param name="txtTaiKhoan">txtTaiKhoan</param>
        /// <param name="txtMatKhau">txtMatKhau</param>
        /// <returns></returns>
        private User KiemTraDangNhap(string txtTaiKhoan, string txtMatKhau)
        {
            bllUser = new BLLUser(FrmMain.Instance.userDataPath);
            User user = bllUser.LoginCheck(txtTaiKhoan, txtMatKhau);

            return user;
        }
     private   bool trangThaiDongForm = false;

        public string ThongTin { get; internal set; }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (trangThaiDongForm == true)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmQuanLyUser_Modifiles frmQuanLy = new FrmQuanLyUser_Modifiles(null);
            frmQuanLy.isEditting = false;
            frmQuanLy.ShowDialog();
        }

        private void dkTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
