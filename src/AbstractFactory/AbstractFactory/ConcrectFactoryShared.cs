using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.ConcrectClass;
using AbstractFactory.Interfaces;

namespace AbstractFactory.AbstractFactory
{
    public class ConcrectFactoryShared : IAbstractFactory
    {
        public IAbstractProductDatasul CreateProductDatasul() => 
            new ConcrectProductDatasulShared();

        public IAbstractProductProtheus CreateProductProtheus() =>
            new ConcrectProductProtheusShared();

        public IAbstractProductRM CreateProductRM() =>
            new ConcrectProductRMShared();
    }
}