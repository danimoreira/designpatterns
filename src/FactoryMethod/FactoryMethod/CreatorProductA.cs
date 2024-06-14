using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethod.Product;

namespace FactoryMethod.CreatorProduct
{
    public class CreatorProductA : IFactoryMethod
    {
        public IProduct Create()
        {
            return new ProductA("Produto A", "Windows", "SQL Server");
        }

        public void Deploy()
        {
            Console.WriteLine("Deploy realizado para o produto A");
        }
    }
}