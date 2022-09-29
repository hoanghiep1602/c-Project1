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
    public partial class QuanLiNguoiDung_Modified : Form
    {
        public QuanLiNguoiDung_Modified()
        {
            InitializeComponent();
        }
        public User user;
        public bool isAdd = false;
        BLLUser bd;
        private void QuanLiNguoiDung_Modified_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ClsMain.pathUser);
            if (isAdd)
            {
                txtID.Text = HamTangID().ToString();
                txtID.Enabled = false;
            }
            else
            {
                txtID.Enabled = false;
                txtID.Text = user.ID.ToString(); txtID.Enabled = false;
                txtHoVaTen.Text = user.HoVaTen;
                txtTaiKhoan.Text = user.TaiKhoan;
                txtMatKhau.Text = user.MatKhau;
                txtMatKhau.Enabled = false;
                ckbNhomatkhau.Checked = user.NhoMatKhau;
            }
        }
        private int HamTangID()
        {
            //Lấy ID lớn nhất 
            int max = 0;
            foreach (User item in ClsMain.users)
            {
                if (item.ID >= max)
                    max = item.ID;
            }
            //Id lớn nhất +1
            return max + 1;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)


        {
            //Kiểm tra ràng buột 
            if (!string.IsNullOrEmpty(txtHoVaTen.Text))
            {
                if (!string.IsNullOrEmpty(txtTaiKhoan.Text))
                {
                    if (!string.IsNullOrEmpty(txtMatKhau.Text))
                    {
                        user = new User()
                        {
                            ID = Convert.ToInt32(txtID.Text),
                            HoVaTen = txtHoVaTen.Text,
                            TaiKhoan = txtTaiKhoan.Text,
                            MatKhau = txtMatKhau.Text,
                            NhoMatKhau = ckbNhomatkhau.Checked
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
                        txtMatKhau.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTaiKhoan.Focus();
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập họ và tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoVaTen.Focus();
            }
        }

    }
}
