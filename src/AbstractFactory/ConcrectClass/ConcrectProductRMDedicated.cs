using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcrectClass
{
    public class ConcrectProductRMDedicated : IAbstractProductRM
    {
        public string DatabaseType { get; set; } = "SqlServer";
        public string OperatingSystem { get; set; } = "Windows";
        public string InstanceType { get; set; } = "Dedicated";
    }
}