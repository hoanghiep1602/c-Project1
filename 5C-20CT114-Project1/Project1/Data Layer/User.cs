using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Data_Layer
{
    public class User
    {
        //Field
        private long iD;
        private string taiKhoan;
        private string matKhau;
        private string hoVaTen;
        private bool nhoMatKhau;

        public User(string taiKhoan, string matKhau, string hoVaTen, bool nhoMatKhau)
        {
            this.iD = 0;
            this.taiKhoan = taiKhoan;
            this.matKhau = matKhau;
            this.hoVaTen = hoVaTen;
            this.nhoMatKhau = nhoMatKhau;
        }
        public User()
        {
            this.iD = 0;
            this.taiKhoan = "";
            this.matKhau = "";
            this.hoVaTen = "";
            this.nhoMatKhau = false;
        }

        //Properties
        public long ID
        {
            get { return iD; }
            set { iD = value; }
        }
        public string TaiKhoan
        { 
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
        public string MatKhau
        {
            get
            {
                return matKhau;
            }
            set
            {
                matKhau = value;
            }
        }
        public string HoVaTen 
        {
            get { return hoVaTen; } 
            set { hoVaTen = value; } 
        }
        public bool NhoMatKhau
        { 
            get { return nhoMatKhau; }
            set { nhoMatKhau = value; }
        }

        public User DocUser(string line)
        {
            User user = new User();//khoi tao mot user
            string[] mang = line.Split(',');
            user.ID = Convert.ToInt64(mang[0]);
            user.TaiKhoan = mang[1];
            user.MatKhau = mang[2];
            user.HoVaTen = mang[3];
            user.NhoMatKhau = Convert.ToBoolean(mang[4]);

            return user;
        }
        public void GhiUser(StreamWriter streamWriter)
        {
            streamWriter.WriteLine(string.Format("{0},{1},{2},{3},{4}", ID, TaiKhoan, MatKhau, HoVaTen, NhoMatKhau));
        }
    }
}
