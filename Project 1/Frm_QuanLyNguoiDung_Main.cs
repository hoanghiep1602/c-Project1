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

namespace FrmMain
{
    public partial class Frm_QuanLyNguoiDung_Main : Form
    {
        public Frm_QuanLyNguoiDung_Main()
        {
            InitializeComponent();
        }
        BLLUser bd;

        private void HienThiDanhSachUsers()
        {
            
            ClsMain.users = bd.GetUsers();
            var bindingList = new BindingList<User>(ClsMain.users);
            var source = new BindingSource(bindingList, null);

            dgvUsers.DataSource = source;
        }

        User user = null;

        private void dgvUsers_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.Rows.Count > 0)
            {
                user = new User()
                {
                    ID = Convert.ToInt32(dgvUsers.CurrentRow.Cells["colID"].Value.ToString()),
                    HoVaTen = dgvUsers.CurrentRow.Cells["colHoVaTen"].Value.ToString(),
                    TaiKhoan = dgvUsers.CurrentRow.Cells["colTaiKhoan"].Value.ToString(),
                    MatKhau = dgvUsers.CurrentRow.Cells["colMatKhau"].Value.ToString(),
                    NhoMatKhau = Convert.ToBoolean(dgvUsers.CurrentRow.Cells["colNhoMatKhau"].Value.ToString())

                };
            }
        }

        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            Frm_QuanLyNguoiDung_Modified frm_QuanLyNguoiDung_Modified = new Frm_QuanLyNguoiDung_Modified();
            frm_QuanLyNguoiDung_Modified.isAdd = true;
            frm_QuanLyNguoiDung_Modified.ShowDialog();
            HienThiDanhSachUsers();
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            if (user != null)
            {

                Frm_QuanLyNguoiDung_Modified frmQuanLyNguoiDung_Modified = new Frm_QuanLyNguoiDung_Modified();
                frmQuanLyNguoiDung_Modified.user = user;
                frmQuanLyNguoiDung_Modified.isAdd = false;
                frmQuanLyNguoiDung_Modified.ShowDialog();
                /*Frm_QuanLyNguoiDung_Modified frmQuanLyNguoiDung_Modified = new Frm_QuanLyNguoiDung_Modified();
                frmQuanLyNguoiDung_Modified.BringToFront();
                frmQuanLyNguoiDung_Modified.TopMost = true;
                frmQuanLyNguoiDung_Modified.Focus();
                frmQuanLyNguoiDung_Modified.user = user;
                frmQuanLyNguoiDung_Modified.isAdd = false;
                frmQuanLyNguoiDung_Modified.ShowDialog();*/
                HienThiDanhSachUsers();
            }
        }

        

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HienThiDanhSachUsers();
        }

        private void Frm_QuanLyNguoiDung_Main_Load(object sender, EventArgs e)
        {
            bd = new BLLUser(ClsMain.pathUser);
            HienThiDanhSachUsers();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                int index = 0;
                foreach (User item in ClsMain.users.ToList())
                {
                    if (item.ID == user.ID)
                    {
                        /*item.ID = user.ID;
                        item.HoVaTen = user.HoVaTen;
                        item.TaiKhoan = user.TaiKhoan;
                        item.MatKhau = user.MatKhau;
                        item.NhoMatKhau = user.NhoMatKhau;
                        ClsMain.users.RemoveAt(item);
                        HienThiDanhSachUsers();
                        user = null;
                        break;
                        ClsMain.UpdateData(ClsMain.pathUser, ClsMain.users);*/
                        ClsMain.users.RemoveAt(index);
                        break;
                    }
                    index++;
                }
                if (bd.Capnhatdulieu(ClsMain.users))
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
        
    }
}
