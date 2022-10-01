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
    public partial class FrmMain : Form
    {
        public static FrmMain Instance;
        public string userDataPath { get; private set; }
        public FrmMain()
        {
            Instance = this;
            userDataPath = string.Format(@"{0}/user.init", Application.StartupPath);
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LoadFormLogin();
        }

        private void LoadFormLogin()
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            
        }

        public void SetUserInfo(User user)
        {
            lblTaiKhoan.Text = string.Format("Hệ thống đăng nhập bởi: {0}", user.HoVaTen);

            lblThoiGian.Text = string.Format("Thời gian: {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = string.Format("Thời gian: {0:dd/MM/yyyy HH:mm:ss}", DateTime.Now);
            timer1.Start();

        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            LoadFormLogin();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void ManageUser_Click(object sender, EventArgs e)
        {
            
            FrmQuanLyUser_Main frmQuanlyNguoiDung = new FrmQuanLyUser_Main();
            frmQuanlyNguoiDung.ShowDialog();
        
        }

    }
}
