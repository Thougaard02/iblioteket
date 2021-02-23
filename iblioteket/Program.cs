using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iblioteket
{
    class Program
    {
        static List<Book> rentBooks = new List<Book>();
        static void Main(string[] args)
        {
            Libary rent = new Libary();
            rent.SelectBookToRent();
        }
    }
}
