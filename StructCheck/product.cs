using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructCheck
{
    internal struct Product
    {
        private string name;
        private double cost;
        private float count;
        private double discount;

        public Product(string n = "Пиво Оболонь Светлое", double c = 27, float coun = 2, double d = 10)
        {
            name = n;
            cost = c;
            count = coun;
            discount = d;
            PriceCalculation();
        }

        public double PriceCalculation()
        {
            return cost = count * (cost - ((cost * discount) / 100));
        }
            
        public void Print()
        {
            Console.Write(name + " X" + count + " " + cost);
        }
    }
}
