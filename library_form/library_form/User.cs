using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_form
{
    [Serializable]
    public class User
    {
        public String ID { get; set; }
        public String name { get; set; }
        public String age { get; set; }
        public String sex { get; set; }
        public String ethnic { get; set; }
        public String brithday { get; set; }
        public String register { get; set; }
        public List<Book> books { get; set; }
        
        //添加用户
        public void Add()
        {
            this.ID = Guid.NewGuid().ToString();
            this.books = new List<Book>();
            GlobalDatas.user.Add(this);

            Storage.Serialize<User>(GlobalDatas.user,
                Storage.UserFile);
        }

        //借书的操作，更新书籍
        public void UpdateBorrowBook(int index,Book newbook,string startime,string endtime)
        {
            newbook.startime = startime;
            newbook.endtime = endtime;
            GlobalDatas.user[index].books.Add(newbook);
            Storage.Serialize<User>(GlobalDatas.user,
                Storage.UserFile);
        }

        public void BackBook(int userindex,int bookindex)
        {
            GlobalDatas.user[userindex].books.RemoveAt(bookindex);
            Storage.Serialize<User>(GlobalDatas.user,
                Storage.UserFile);
        }

        //删除用户
        public void Delete(int index)
        {
            GlobalDatas.user.RemoveAt(index);
            Storage.Serialize<User>(GlobalDatas.user,
                    Storage.UserFile);

        }

        //搜索用户
        public User Search(String ID, String name)
        {
            List<User> list = Storage.Deserialize<User>(Storage.UserFile);
            if (ID != "" && name != "")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (name == list[i].name&&ID == list[i].ID)
                    {
                        return list[i];
                    }
                }
            }
            else if (ID != "")
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (ID == list[i].ID)
                    {
                        return list[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (name == list[i].name)
                    {
                        return list[i];
                    }
                }
            } 
            return null;
        }

        public static List<User> LoadAll()
        {
            List<User> list = Storage.Deserialize<User>(Storage.UserFile);

            if (list == null)
            {
                list = new List<User>();
            }

            return list;
        }
    }
}
