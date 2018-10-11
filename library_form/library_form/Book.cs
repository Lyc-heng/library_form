using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_form
{
    [Serializable]
    public class Book
    {
            public String ID { get; set; }
            public String name { get; set; }
            public String writter { get; set; }
            public String time { get; set; }
            public String publisher { get; set; }
            public String page { get; set; }
            public String borrow { get; set; }
            public String startime { get; set; }
            public String endtime { get; set; }

        //添加书籍
        public void Add()
        {
            this.ID = Guid.NewGuid().ToString();
            this.borrow = "可以";
            GlobalDatas.books.Add(this);

            Storage.Serialize<Book>(GlobalDatas.books,
                Storage.BookFile);
        }

        //删除书籍
        public void Delete(int index)
        {
            GlobalDatas.books.RemoveAt(index);
            Storage.Serialize<Book>(GlobalDatas.books,
                    Storage.BookFile);
        }

        //更新书籍状态
        public void Update(int index,string newstate, string newstarttime, string newendtime)
        {
            GlobalDatas.books[index].borrow = newstate;
            GlobalDatas.books[index].startime = newstarttime;
            GlobalDatas.books[index].endtime = newendtime;
            Storage.Serialize<Book>(GlobalDatas.books,
                    Storage.BookFile);
        }

        //还书的操作
        public void BackBook(string id, string name, string writter, string time, string publisher, string page)
        {
            List<Book> remineder = Storage.Deserialize<Book>(Storage.BookFile);
            for(int i = 0; i < remineder.Count; i++)
            {
                if(remineder[i].ID == id&&remineder[i].name==name&&remineder[i].writter==writter&&
                    remineder[i].time == time && remineder[i].publisher == publisher && remineder[i].page == page)
                {
                    GlobalDatas.books[i].borrow = "可以";
                    GlobalDatas.books[i].startime = "";
                    GlobalDatas.books[i].endtime = "";
                    break;
                }

            }
            Storage.Serialize<Book>(GlobalDatas.books,
                    Storage.BookFile);
        }

        //搜索的操作
        public List<Book> Search(string id,string name, string writter, string time, string publisher, string page)
        {
            List<Book> remineder = Storage.Deserialize<Book>(Storage.BookFile);
            if (id != "")
            {
                for (int i = 0; i < remineder.Count; i++)
                {
                    if (remineder[i].ID != id)
                    {
                        remineder.RemoveAt(i);
                        i--;
                    }
                }
            }
            if (name != "")
            {
                for(int i = 0; i < remineder.Count; i++)
                {
                    if(remineder[i].name != name)
                    {
                        remineder.RemoveAt(i);
                        i--;
                    }
                }
            }
            if(writter != "")
            {
                for(int i = 0; i < remineder.Count; i++)
                {
                    if(remineder[i].writter != writter)
                    {
                        remineder.RemoveAt(i);
                        i--;
                    }
                }
            }
            if(time != "")
            {
                for(int i = 0; i < remineder.Count; i++)
                {
                    if(remineder[i].time != time)
                    {
                        remineder.RemoveAt(i);
                        i--;
                    }
                }
            }
            if(publisher != "")
            {
                for(int i = 0; i < remineder.Count; i++)
                {
                    if(remineder[i].publisher != publisher)
                    {
                        remineder.RemoveAt(i);
                        i--;
                    }
                }
            }
            if(page != "")
            {
                for(int i = 0; i < remineder.Count; i++)
                {
                    if(remineder[i].page != page)
                    {
                        remineder.RemoveAt(i);
                        i--;
                    }
                }
            }
            return remineder;
        }

        public static List<Book> LoadAll()
        {
            List<Book> list = Storage.Deserialize<Book>(Storage.BookFile);

            if (list == null)
            {
                list = new List<Book>();
            }

            return list;
        }
    }
}
