using System;
using System.Collections;
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
            ArrayList list = new ArrayList();
            Check check = new Check("АТБ", "Пастера 45", 20, 10, 2022, 11, 43, 0, list);
            Product pivo = new Product("Пиво Оболонь Светлое", 27, 2, 10);
            Product bread = new Product("Хлеб Бородинский", 15, 2, 5);
            Product toy = new Product("Игрушка Медведь", 100, 1, 0);
            Product meat = new Product("Вырезка мясная (свинина)", 200, 2, 8);
            Product cheese = new Product("Сыр Какой-то", 51 , 3 , 15);
            check.AddProduct(pivo);
            check.AddProduct(bread);
            check.AddProduct(toy);
            check.AddProduct(meat);
            check.AddProduct(cheese);
            check.Print();
            
            Console.ReadLine();
        }
    }
}
