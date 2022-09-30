using FrmMain.BussinessLayer;
using FrmMain.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FrmMain
{
    public partial class Frm_QuanLyNguoiDung_Main : Form
    {
        public Frm_QuanLyNguoiDung_Main()
        {
            InitializeComponent();
        }

        BLLUser bd;
        private void button1_Click(object sender, EventArgs e)
        {
            Frm_QuanLyNguoiDung_Modified frm_QuanLyNguoiDung_Modified = new Frm_QuanLyNguoiDung_Modified();
            frm_QuanLyNguoiDung_Modified.isAdd = true;
            frm_QuanLyNguoiDung_Modified.ShowDialog();
            HienThiDanhSachUsers();
        }

        private void Frm_QuanLyNguoiDung_Main_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ClsMain.pathUser);
            HienThiDanhSachUsers();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers_CellContentClick.Rows.Count > 0)
            {
                user = new User()
                {
                    ID = Convert.ToInt32(dgvUsers_CellContentClick.CurrentRow.Cells["colID"].Value.ToString()),
                    HoVaTen = dgvUsers_CellContentClick.CurrentRow.Cells["colHoVaTen"].Value.ToString(),
                    TaiKhoan = dgvUsers_CellContentClick.CurrentRow.Cells["colTaiKhoan"].Value.ToString(),
                    MatKhau = dgvUsers_CellContentClick.CurrentRow.Cells["colMatKhau"].Value.ToString(),
                    NhoMatKhau = Convert.ToBoolean(dgvUsers_CellContentClick.CurrentRow.Cells["colNhoMatKhau"].Value.ToString())

                };
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void HienThiDanhSachUsers()
        {
            ClsMain.users = bd.GetUsers();

            var bindingList = new BindingList<User>(ClsMain.users);
            var source = new BindingSource(bindingList, null);

            dgvUsers_CellContentClick.DataSource = source;
        }

        User user = null;

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (user != null)
            {

                Frm_QuanLyNguoiDung_Modified frm_QuanLyNguoiDung_Modified = new Frm_QuanLyNguoiDung_Modified();
                frm_QuanLyNguoiDung_Modified.isAdd = false;
                frm_QuanLyNguoiDung_Modified.user = user;
                frm_QuanLyNguoiDung_Modified.ShowDialog();
                HienThiDanhSachUsers();
                user = null;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                foreach (User item in ClsMain.users.ToList())
                {
                    if (item.ID == user.ID)
                    {
                        item.ID = user.ID;
                        item.HoVaTen = user.HoVaTen;
                        item.TaiKhoan = user.TaiKhoan;
                        item.MatKhau = user.MatKhau;
                        item.NhoMatKhau = user.NhoMatKhau;
                        ClsMain.users.Remove(item);
                        HienThiDanhSachUsers();
                        user = null;
                        break;
                        ClsMain.CapNhatData(ClsMain.pathUser, ClsMain.users);
                    }
                }
                if (bd.CapNhatDuLieu(ClsMain.users))
                {
                    MessageBox.Show("Cap nhat thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cap nhat khong thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui long chon user");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDanhSachUsers();
        }
    }
}
