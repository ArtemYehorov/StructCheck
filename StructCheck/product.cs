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
            this.name = n;
            this.cost = c;
            this.count = coun;
            this.discount = d;
            this.PriceCalculation();
        }

        public double PriceCalculation()
        {
            return this.cost = count * (cost - ((cost * discount) / 100));
        }
            
        public void Print()
        {
            Console.Write(name + " X" + count + " " + cost);
        }
    }
}
