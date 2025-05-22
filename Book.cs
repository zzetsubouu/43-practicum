using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_practicum
{
    struct Book
    {
        public string title;
        public string authorsName;
        public int releaseDate;
        public int numberOfPages;

        public Book(string title, string authorsName, int releaseDate, int numberOfPages)
        {
            this.title = title;
            this.authorsName = authorsName;
            this.releaseDate = releaseDate;
            this.numberOfPages = numberOfPages;
        }

        public void Output()
        {
            Console.WriteLine($"Книга:\t{title}\tАвтор: {authorsName}\t Дата выпуска: {releaseDate}\t Количество страниц: {numberOfPages}");
        }
    }
}
