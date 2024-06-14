using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public class ProductA : IProduct
    {
        public ProductA(string name, string sO, string databaseDefault)
        {
            Name = name;
            SO = sO;
            DatabaseDefault = databaseDefault;
        }

        public string Name { get; set; }
        public string SO { get; set; }
        public string DatabaseDefault { get; set; }
    }
}