using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbstractFactory.Interfaces;

namespace AbstractFactory.ConcrectClass
{
    public class ConcrectProductProtheusShared : IAbstractProductProtheus
    {
        public string DatabaseType { get; set; } = "Oracle";
        public string OperatingSystem { get; set; } = "Linux";
        public string InstanceType { get; set; } = "Shared";
    }
}