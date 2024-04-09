using lab422;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab422
{
    internal class GearSorter
    {
        private List<Gear> gears { get; set; }

        public GearSorter(List<Gear> gears)
        {
            this.gears = gears;
        }

        public void SortByHierarchy()
        {
            gears.Sort((x, y) => x.Priority.CompareTo(y.Priority));
        }

        public void SortByWeight()
        {
            gears.Sort((x, y) => x.Weight.CompareTo(y.Weight));
        }

        public List<Gear> SortByPrice(double minPrice, double maxPrice)
        {
            return gears.Where(g => g.Price >= minPrice && g.Price <= maxPrice)
                        .OrderBy(g => g.Price)
                        .ToList();
        }

        public double CalculateTotalPrice()
        {
            double totalPrice = 0;
            foreach (var gear in gears)
            {
                totalPrice += gear.Price;
            }
            return totalPrice;
        }
    }
}
