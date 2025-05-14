using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Devices;

namespace Brands
{
    public class KiaomiFactory : ITechFactory
    {
        public IDevice CreateLaptop() => new Laptop("Kiaomi");
        public IDevice CreateNetbook() => new Netbook("Kiaomi");
        public IDevice CreateEBook() => new EBook("Kiaomi");
        public IDevice CreateSmartphone() => new Smartphone("Kiaomi");
    }
}

