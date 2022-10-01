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
    public partial class FrmQuanLyUser_Modifiles : Form
    {
        FrmQuanLyUser_Main data;
        public bool isEditting = false;
        BLLUser bLLUser = new BLLUser(FrmMain.Instance.userDataPath);
        public FrmQuanLyUser_Modifiles(FrmQuanLyUser_Main data = null)
        {
            this.data = data;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmQuanLyUser_Modifiles_Load(object sender, EventArgs e)
        {
            if (isEditting)
            {
                Editting();
            }
            else
            {
                Adding();
            }
        }

        private void Editting()
        {
            this.titleText.Text = "Sửa người dùng";
        }

        public void SetData(User user)
        {
            if (user == null)
                return;

            this.textID.Text = user.ID.ToString();
            this.textName.Text = user.HoVaTen;
            this.textUserName.Text = user.TaiKhoan;
            this.textPassword.Text = user.MatKhau;
            this.chkMatKhau.Checked = user.NhoMatKhau;
        }

        private void Adding()
        {
            this.titleText.Text = "Thêm người dùng";
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.ID = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            user.TaiKhoan = this.textUserName.Text;
            user.MatKhau = this.textPassword.Text;
            user.HoVaTen = this.textName.Text;
            user.NhoMatKhau = this.chkMatKhau.Checked;

            if (isEditting)
            {
                int userIndex = bLLUser.userDao.GetUserIndexByID(user.ID);
                bLLUser.userDao.EditUser(user, userIndex);
            }
            else
            {
                bLLUser.userDao.AddUser(user);
            }

            if (this.data != null)
            {
                data.Refresh();
            }

            this.Close();
        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }
    }
}
