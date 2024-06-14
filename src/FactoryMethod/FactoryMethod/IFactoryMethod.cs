using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FactoryMethod.Product;

namespace FactoryMethod.CreatorProduct
{
    public interface IFactoryMethod
    {
        IProduct Create();
        void Deploy();
    }
}