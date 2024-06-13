using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcrectClass
{
    public class ConcrectProductDatasulShared: IAbstractProductDatasul
    {
        public string DatabaseType { get; set; } = "Progress";
        public string OperatingSystem { get; set; } = "Linux";
        public string InstanceType { get; set; } = "Shared";
    }
}