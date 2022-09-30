using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrmMain.DataLayer
{
    public  class User : IComparable
    {
        //Khoi tao 
        private string iD;
        private string taiKhoan;
        private string matKhau;
        private string hoVaTen;
        private bool nhoMatKhau;

        public string ID { get => iD; set => iD = value; }
        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string HoVaTen { get => hoVaTen; set => hoVaTen = value; }
        public bool NhoMatKhau { get => nhoMatKhau; set => nhoMatKhau = value; }


        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4}", ID, TaiKhoan, MatKhau, HoVaTen, NhoMatKhau.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                return ((User)obj).ID.ToString().Equals(this.ID.ToString());
            }
            return false;
        }

        public int CompareTo(object obj)
        {
            if (obj is User)
            {
                return ((User)obj).ID.CompareTo(this.ID);

            }
            return -1;
        }
    }
}
