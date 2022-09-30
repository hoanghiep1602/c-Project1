using FrmMain.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMain.BussinessLayer
{
    public  class BLLUser
    {
        //  //Hàm tạo 
        UserDao userDao;
        public BLLUser(string path)
        {
            userDao = new UserDao(path);
        }    
        //lay data 
        public bool Kiemtradangnhap(string taiKhoan,string matKhau)
        {
            return userDao.KiemTraDangNhap( taiKhoan,  matKhau);
        }

        public List<User> GetUsers()
        {
            return userDao.GetUsers();
        }
        public bool Capnhatdulieu(List<User> users)
        {
            return userDao.CapNhatDuLieu(users);
        }

    }
}
