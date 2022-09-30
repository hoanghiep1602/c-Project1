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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
        private void ShowFormLogin()
        {
            FrmLogin frmDangNhap = new FrmLogin();
            frmDangNhap.ThongTin = "Project 1";
            frmDangNhap.ShowDialog();
            lblTime.Text = DateTime.Now.ToString();
            //tmrGioHeThong.Start();
            lblThongTinDangNhap.Text = string.Format("Hệ thống được đăng nhập vào thời gian: {0}");
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            ShowFormLogin();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*  private void tmrGioHeThong_Tick(object sender, EventArgs e)
      {
          lblTime.Text = DateTime.Now.ToString();
      }*/

        private void mnuQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            FrmQuanLyNguoiDung_Main frmQuanLyNguoiDung_Main = new FrmQuanLyNguoiDung_Main();
            frmQuanLyNguoiDung_Main.showDialog();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau frm_DoiMatKhau = new Frm_DoiMatKhau();
            frm_DoiMatKhau.showDialog();
        }
    
    }
}
