using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43_practicum
{
    struct Notebook
    {
        public string manufacturer;
        public string model;
        public double price;

        public Notebook(string manufacturer, string model, double price)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
        }

        public void Output()
        {
            Console.WriteLine($"Ноутбук:\tПроизводитель: {manufacturer}\t Модель: {model}\t Cтоимость: {price}");
        }
    }
}
