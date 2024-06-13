using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractFactory
{
    public interface IAbstractFactory
    {
        IAbstractProductRM CreateProductRM();
        IAbstractProductProtheus CreateProductProtheus();
        IAbstractProductDatasul CreateProductDatasul();
    }
}