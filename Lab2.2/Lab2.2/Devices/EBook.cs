using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Devices
{
    public class EBook : IDevice
    {
        private string _brand;
        public EBook(string brand) => _brand = brand;
        public string GetInfo() => $"{_brand} EBook";
    }
}

