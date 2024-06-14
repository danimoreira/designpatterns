using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FactoryMethod.Product
{
    public interface IProduct
    {
        string Name { get; set; }
        string SO { get; set; }
        string DatabaseDefault { get; set; }
    }
}