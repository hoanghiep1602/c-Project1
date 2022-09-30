using FrmMain.BussinessLayer;
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
        BLLUser bd;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ClsMain.pathUser);
            FrmLogin frmDangNhap = new FrmLogin();
            frmDangNhap.ThongTin = "Project 1";
            frmDangNhap.ShowDialog();
            lblTime.Text = DateTime.Now.ToString();
            //tmrGioHeThong.Start();
            lblThongTinDangNhap.Text = string.Format("Hệ thống được đăng nhập vào thời gian: {0}",ClsMain.taiKhoan);
        }
        /*private void ShowFormLogin()
        {
            FrmLogin frmDangNhap = new FrmLogin();
            frmDangNhap.ThongTin = "Project 1";
            frmDangNhap.ShowDialog();
            lblTime.Text = DateTime.Now.ToString();
            //tmrGioHeThong.Start();
            lblThongTinDangNhap.Text = string.Format("Hệ thống được đăng nhập vào thời gian: {0}");
        }*/

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            //ShowFormLogin();
            FrmLogin frmDangNhap = new FrmLogin();
            frmDangNhap.ThongTin = "Project 1";
            frmDangNhap.ShowDialog();
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
            Frm_QuanLyNguoiDung_Main frmQuanLyNguoiDung_Main = new Frm_QuanLyNguoiDung_Main();
            frmQuanLyNguoiDung_Main.ShowDialog();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            Frm_DoiMatKhau frm_DoiMatKhau = new Frm_DoiMatKhau();
            frm_DoiMatKhau.ShowDialog();
        }
    
    }
}
