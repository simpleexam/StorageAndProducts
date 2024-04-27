using System.Net.Http.Headers;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Storage storage1 = new Storage(); //склад создан
            string[] productNames = { "milk", "coffe","bread", "tea", 
                                        "shugar", "cacao", "coffe", "tea",
                                            "milk", "coffe","bread", "tea" };
            
            Random rnd = new Random();
            //добавление 10 продуктов (имена продуктов берутся из подготовленного массива productNames) 
            for (int i = 0; i< 10; i++)
            {
                Product product = new Product(productNames[i], new DateOnly
                                                                    (
                                                                        2024,
                                                                        rnd.Next(1,13), //месяц от 1 до 12 вкл
                                                                        rnd.Next(1,31)  // день от 1 до 30 вкл
                                                                    ));
                storage1.AddProduct(product);  //сгенерированный продукт добавляется в список продуктов склада 
            }
            Console.WriteLine();
            storage1.PrintInfo();   //вывод информации по содержимому класса
            
            Console.WriteLine();
            storage1.ClearStorage(); //очистка склада от просрочки

            Console.WriteLine();
            storage1.PrintInfo();   //вывод информации по содержимому класса

        }
    }
}