using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StructCheck
{
    internal class Program
    {
        static void Main()
        {
            LinkedList<Product> list = new LinkedList<Product>();
            Check check = new Check("АТБ", "Пастера 45", 20, 10, 2022, 11, 43, 0, null);
            Product pivo = new Product("Пиво Оболонь Светлое", 27, 2, 10);
            Product bread = new Product("Хлеб Бородинский", 15, 2, 5);
            Product toy = new Product("Игрушка Медведь", 100, 1, 0);
            Product meat = new Product("Вырезка мясная (свинина)", 200, 2, 8);
            Product cheese = new Product("Сыр Какой-то", 51 , 3 , 15);
            list.AddLast(pivo);
            list.AddLast(bread);
            list.AddLast(toy);
            list.AddLast(meat);
            list.AddLast(cheese);
            check.Product = list;
            check.Print();
            
            Console.ReadLine();
        }
    }
}
