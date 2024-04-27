using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Product
    {
        private string? _title; //название
        private DateOnly _expirationDate; //срок годности

        public string? Title
        {
            get
            {
                return _title;
            }
            set
            {
                if(value.Length < 3)
                {
                    throw new ArgumentException();
                }
                else 
                    _title = value;
            }
        }
        public DateOnly ExpirationDate //свойство только для чтения
        {
            //отсутствует блок set
            get { return _expirationDate; }
        }

        public Product(string? Title, DateOnly expirationDate)
        {
            this.Title=Title;
            _expirationDate=expirationDate;
        }

        public string GetInfo()
        {
            return new string($"продукт {Title}; срок годности: {ExpirationDate}");
        }
    }
}
