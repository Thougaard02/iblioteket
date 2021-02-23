using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iblioteket
{
    class Libary
    {
        Stack<Book> rentedBooks = new Stack<Book>();
        List<Book> avaiableBooks = new List<Book>();
        int userinput;
        public void AddBooks()
        {
            avaiableBooks.Add(new Book("Harry Potter Philosopher's Stone", "J.K Rowling", 1997, 223));
            avaiableBooks.Add(new Book("Harry Potter Chamber of Secrets", "J.K Rowling", 1998, 251));
            avaiableBooks.Add(new Book("Harry Potter Prisoner of Azkaban", "J.K Rowling", 1999, 317));
            avaiableBooks.Add(new Book("Harry Potter Goblet of Fire", "J.K Rowling", 2000, 636));
            avaiableBooks.Add(new Book("Harry Potter Order of the Phoenix", "J.K Rowling", 2003, 766));
            avaiableBooks.Add(new Book("Harry Potter Half-Blood Prince", "J.K Rowling", 2005, 607));
            avaiableBooks.Add(new Book("Harry Potter Deathly Hallows", "J.K Rowling", 2007, 607));
        }

        public void ShowBooks()
        {
            for (int i = 0; i < avaiableBooks.Count; i++)
            {
                Console.WriteLine($"{i + 1} {avaiableBooks[i].Title}");
            }
        }

        public void SelectBookToRent()
        {
            AddBooks();
            while (avaiableBooks.Count != 0)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine();
                Console.WriteLine("           Select you want to rent Books          ");
                Console.WriteLine();
                Console.WriteLine("==================================================");
                Console.WriteLine();
                ShowBooks();
                userinput = Convert.ToInt32(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        rentedBooks.Push(avaiableBooks[0]);
                        avaiableBooks.RemoveAt(0);
                        ShowBooks();
                        break;
                    case 2:
                        rentedBooks.Push(avaiableBooks[1]);
                        avaiableBooks.RemoveAt(1);
                        ShowBooks();
                        break;
                    case 3:
                        rentedBooks.Push(avaiableBooks[2]);
                        avaiableBooks.RemoveAt(2);
                        ShowBooks();
                        break;
                    case 4:
                        rentedBooks.Push(avaiableBooks[3]);
                        avaiableBooks.RemoveAt(3);
                        ShowBooks();
                        break;
                    case 5:
                        rentedBooks.Push(avaiableBooks[4]);
                        avaiableBooks.RemoveAt(4);
                        ShowBooks();
                        break;
                    case 6:
                        rentedBooks.Push(avaiableBooks[6]);
                        avaiableBooks.RemoveAt(6);
                        ShowBooks();
                        break;
                    case 7:
                        rentedBooks.Push(avaiableBooks[6]);
                        avaiableBooks.RemoveAt(6);
                        ShowBooks();
                        break;
                    default:
                        break;
                }
            }
            while (rentedBooks.Count != 0)
            {
                Console.Clear();
                Console.WriteLine("==================================================");
                Console.WriteLine();
                Console.WriteLine("               Books you have rented              ");
                Console.WriteLine();
                Console.WriteLine("==================================================");
                Console.WriteLine();

                Console.WriteLine($"You have rented {rentedBooks.Peek().Title}");
                Console.WriteLine("Press any key");
                Console.ReadKey();
                rentedBooks.Pop();
            }
        }
    }
}
