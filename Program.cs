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
            Notebook notebook = new Notebook("Lenovo", "80RJ", 300);
            notebook.Output();
            Console.ReadKey();
        }
    }
}
