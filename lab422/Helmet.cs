using lab422;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab422
{
    internal class Helmet : Gear
    {
        public Helmet(string name, double price, double weight, double priority) : base(name, price, weight, priority)
        {
        }
    }
}
