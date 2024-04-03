using System;
using System.Collections.Generic;
using System.Linq;

namespace lab422
{
    internal class Gear
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public double Priority { get; set; }

        public Gear(string name, double price, double weight, double priority)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Priority = priority;
        }


        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
