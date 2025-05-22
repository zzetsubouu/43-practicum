using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_practicum
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }

        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }

        static void Main(string[] args)
        {
            MyClass classPrimer = new MyClass();
            MyStruct structPrimer = new MyStruct();

            classPrimer.change = "не изменено";
            structPrimer.change = "не изменено";

            ClassTaker(classPrimer);
            StructTaker(structPrimer);

            Console.WriteLine("Класс: " + classPrimer.change);
            Console.WriteLine("Структура: " + structPrimer.change);

            Console.ReadLine();
        }
    }
}
