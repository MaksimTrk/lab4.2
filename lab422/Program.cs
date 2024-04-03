using lab422;
using static System.Reflection.Metadata.BlobBuilder;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
        List<Gear> gears = new List<Gear>
            {
                new Gear("Helmet BEON", 2500, 1.2, 1),
                new Gear("Jacket Daqinese", 3000, 1, 2),
                new Gear("Boots Alpinestars", 9000, 2, 3),
                new Gear("Gloves Furygan", 1500, 0.2, 3)
            };

        GearSorter gearSorter = new GearSorter();

        gearSorter.SortByHierarchy(gears);
        Console.WriteLine("Sorted by priority:");
        foreach (var gear in gears)
        {
            Console.WriteLine(gear);
        }

        gearSorter.SortByWeight(gears);
        Console.WriteLine("\nSorted by weight:");
        foreach (var gear in gears)
        {
            Console.WriteLine(gear);
        }
        double total = gearSorter.CalculateTotalPrice(gears);
        Console.WriteLine($"\nTotal price of all gear: {total}\n");
        Console.WriteLine("\nEnter min price:");
        double min = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter max price:");
        double max = double.Parse(Console.ReadLine());
        var gearsInRange = gearSorter.SortByPrice(gears, min, max);
        Console.WriteLine($"\nGears in the price range of {min} to {max}:");
        foreach (var gear in gearsInRange)
        {
            Console.WriteLine(gear);
        }
    }
}
