using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[2];
            string[] title = { "крутая книга", "Война и мир" };
            string[] author = { "матвей", "Лев Толстой" };
            int[] release = { 2025, 1867 };
            int[] pages = { 5, 1300 };
            for (int i = 0; i < books.Length; i++)
            {
                books[i].title = title[i];
                books[i].authorsName = author[i];
                books[i].releaseDate = release[i];
                books[i].numberOfPages = pages[i];
                books[i].Output();
            }
            Console.ReadKey();
        }
    }
}
