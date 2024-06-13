using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IAbstractProduct
    {
        public string DatabaseType { get; set; }        
        public string OperatingSystem { get; set; }
        public string InstanceType { get; set; }
    }
}