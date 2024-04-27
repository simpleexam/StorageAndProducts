using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Storage
    {
        private const int _capacity = 10; //приватное поле емкости склада
        
        List<Product> products; //список продуктов на хранении
        public List<Product> Products { get {  return products; } }

        public void AddProduct(Product sourse)
        {
            if(products.Count < _capacity)
                products.Add(sourse); //добавление продукта во внутренний список продуктов
            else
            {
                throw new Exception("склад заполнен");
            }
        }

        public void RemoveProduct(Product sourse)
        {
            products.Remove(sourse); //удаление продукта из списка
        }

        public Storage()  //конструктоа класса склада, инициализирующий (выделяющий память ) для списка продуктов
        {
            products = new List<Product>();
        }

        public void PrintInfo()
        {
            string result = $"на складе занято {products.Count} мест:"; //заголовок результата
            //дохапись в результат информации по всем продуктам в списке
            foreach(Product p in products) 
            { 
                result += "\n\t"+p.GetInfo();
            }
            Console.WriteLine(result);  
        }
        //создать метод, который удаляет просроченные товары из склада
        public void ClearStorage()
        {
            for(int i=0; i< products.Count; i++)
            {
                //если срок годности товара меньше или равен текущей дате
                if (products[i].ExpirationDate <= DateOnly.Parse(DateTime.Now.ToShortDateString()))
                    products.Remove(products[i]);
            }
            Console.WriteLine("склад очищен от просрочки");
            this.PrintInfo();
        }
        
    }
}
