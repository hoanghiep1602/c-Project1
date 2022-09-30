using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMain
{
    class ClsMain
    {
        public static string taiKhoan = string.Empty;
        public static string pathUser = string.Format(@"{0}\users.ini", Application.StartupPath);
        public static List<User> users = null;

        public static void UpdateData(string path,List<User> users)
        {
            BLLUser bd = new BLLUser(path);
            if(bd.UpdateData(ClsMain.users))
            {
                MessageBox.show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("cập nhật không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
