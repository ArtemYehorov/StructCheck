using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace StructCheck
{
    internal struct Check
    {
        private string namefirm;
        private string addresfirm;
        private float day;
        private float month;
        private float year;
        private float hour;
        private float minute;
        private LinkedList<Product> product;
        private double price;

        public Check(string namef = "АТБ", string addressf = "Пастера 45", float d = 20, float m = 10, float y = 2022, float h = 11, float mi = 43, double pric = 0, LinkedList<Product> p = null)
        {
            namefirm = namef;
            addresfirm = addressf;
            day = d;
            month = m;
            year = y;
            hour = h;
            minute = mi;
            price = pric;
            product = p;
        }

        public string NameFirm { get { return namefirm; } set { namefirm = value; } }

        public string AddresFirm { get { return addresfirm; } set { addresfirm = value; } }

        public float Day { get { return day; } set { day = value; } }

        public float Month { get { return month; } set { month = value; } }

        public float Year { get { return year; } set { year = value; } }

        public float Hour { get { return hour; } set { hour = value; } }

        public float Minute { get { return minute; } set { minute = value; } }

        public LinkedList<Product> Product { set { product = value; } }

        public double Price { get { return price; } set { price = value; } }

        public void AddProduct(Product p)
        {
            product.AddLast(p);
        }

        private void CountPrice()
        {
            foreach (var item in product)
            {
               price += item.PriceCalculation();
            }
        }

        public void Print()
        {
            CountPrice();
            Console.WriteLine("\t\t " + namefirm);
            Console.WriteLine("\t\t " + addresfirm);
            Console.WriteLine("\t\t Датта: " + day +"." + month +"." + year + "  " + hour + ":" + minute);
            foreach (var item in product)
            {
                Console.Write("\t\t ");
                item.Print();
                Console.WriteLine();
            }
            Console.WriteLine("\t\t Общая цена:  " + price);
            Console.WriteLine("\t\t Консультация +380934872734");
        }

    }
}
