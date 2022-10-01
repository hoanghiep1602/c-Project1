using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1.Data_Layer
{
   public class UserDao
    {
        private List<User> listUser;
        public List<User> ListUser { get { return listUser; } set { listUser = value; } }

        public string userDataPath;

        Database database;
        public UserDao()
        {
            listUser = new List<User>()
            {
                new User(){ID=0,TaiKhoan="admin",MatKhau="admin",HoVaTen="Phu",NhoMatKhau=true}

            };
        }
        public UserDao(string path)
        {
            this.userDataPath = path;
            listUser = new List<User>();
            database = new Database(path);
            listUser = database.DocUser();
        }

        //Thuc hien cac phuong thuc

        public User GetUserByID(long id)
        {
            foreach(User user in listUser)
            {
                if (user.ID == id)
                    return user;
            }

            return null;
        }

        public int GetUserIndexByID(long id)
        {
            for (int i = 0; i < listUser.Count; i++)
            {
                if (listUser[i].ID == id)
                    return i;
            }

            return 0;
        }

        //them
        public void AddUser(User data)
        {
            listUser.Add(data);
            database = new Database(userDataPath);
            database.GhiFile(userDataPath, listUser);
        }
        //sua
        public void EditUser(User data, int index)
        {
            listUser[index] = data;
            database = new Database(userDataPath);
            database.GhiFile(userDataPath, listUser);
        }
        //xoa
        public void DeleteUser(User user)
        {
            listUser.Remove(user);
            MessageBox.Show(ListUser.Count.ToString());
            database = new Database(userDataPath);
            database.GhiFile(userDataPath, listUser);
        }

        public void SaveListUser(List<User> users)
        {
            database = new Database(userDataPath);
            database.GhiFile(userDataPath, users);
        }
    }
}
