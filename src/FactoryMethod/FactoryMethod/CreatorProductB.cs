using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethod.Product;

namespace FactoryMethod.CreatorProduct
{
    public class CreatorProductB : IFactoryMethod
    {
        public IProduct Create()
        {
            return new ProductA("Produto B", "Linux", "Oracle");
        }

        public void Deploy()
        {
            Console.WriteLine("Deploy realizado para o produto B");
        }
    }
}