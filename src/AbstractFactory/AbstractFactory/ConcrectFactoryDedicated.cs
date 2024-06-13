using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.ConcrectClass;
using AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractFactory
{
    public class ConcrectFactoryDedicated : IAbstractFactory
    {
        public IAbstractProductDatasul CreateProductDatasul() => 
            new ConcrectProductDatasulDedicated();

        public IAbstractProductProtheus CreateProductProtheus() => 
            new ConcrectProductProtheusDedicated();

        public IAbstractProductRM CreateProductRM() => 
            new ConcrectProductRMDedicated();
    }
}