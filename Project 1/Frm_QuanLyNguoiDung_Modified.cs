using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmMain.BussinessLayer;
using FrmMain.DataLayer;

namespace FrmMain
{
    public partial class Frm_QuanLyNguoiDung_Modified : Form
    {
        public Frm_QuanLyNguoiDung_Modified()
        {
            InitializeComponent();
        }
        public User user;
        public bool isAdd = false;
        BLLUser bd;
        private void Frm_QuanLyNguoiDung_Modified_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ClsMain.pathUser);
            if(isAdd)
            {
                txtID.Text = HamTangID().ToString();
                txtID.Enabled = false;
            }
            else
            {
                txtID.Enabled = false;
                txtID.Text = user.HoVaTen;
                txtTaikhoan.Text = user.TaiKhoan;
                txtMatkhau.Text = user.MatKhau;
                txtMatkhau.Enabled = false;
                ckbNhoMatKhau.Checked = user.NhoMatKhau;
            }

        }
        private int HamTangID()  
        {
            //lấy được id lớn nhất
            int max = 0;
            foreach(User item in ClsMain.users)
            {
                if (item.ID >= max)
                    max = item.ID;
            }
            //cong max+1
            return max + 1;

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {


            //kiểm tra ràng buộc
            if (!string.IsNullOrEmpty(txtHovaTen.Text))
            {
                if (!string.IsNullOrEmpty(txtTaikhoan.Text))
                {
                    if (!string.IsNullOrEmpty(txtMatkhau.Text))
                    {
                        user = new User()
                        {
                            ID = Convert.ToInt32(txtID.Text),
                            HoVaTen = txtHovaTen.Text,
                            TaiKhoan = txtTaikhoan.Text,
                            MatKhau = txtMatkhau.Text,
                            NhoMatKhau = ckbNhoMatKhau.Checked
                        };
                        if (isAdd)
                        {
                            ClsMain.users.Add(user);
                        }
                        else
                        {
                            foreach (User item in ClsMain.users)
                            {
                                if (item.ID == user.ID)
                                {
                                    item.ID = user.ID;
                                    item.HoVaTen = user.HoVaTen;
                                    item.TaiKhoan = user.TaiKhoan;
                                    item.MatKhau = user.MatKhau;
                                    item.NhoMatKhau = user.NhoMatKhau;
                                }
                            }
                        }
                        //ghi file
                        ClsMain.CapNhatData(ClsMain.pathUser, ClsMain.users);
                    }
                    else
                    {
                        MessageBox.Show("Chưa nhập Mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtMatkhau.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaikhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHovaTen.Focus();
            }
        }


    }
}
