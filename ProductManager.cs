using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncelle");
        }
        public void Delete(Product product)
        {
            Console.WriteLine(product.ProductName + " silindi");
        }
    }
}
