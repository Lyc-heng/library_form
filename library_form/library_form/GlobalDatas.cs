using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_form
{
    public class GlobalDatas
    {
        public static List<Book> books { get; set; }
        public static List<User> user { get; set; }

        static GlobalDatas()
        { 
            books = Book.LoadAll();
            user = User.LoadAll();
        }
    }
}
