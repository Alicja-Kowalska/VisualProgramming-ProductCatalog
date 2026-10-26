using System;
using ProductCatalog.Library.BO;

namespace ProductCatalog.TlsApp
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            CarModel myCar = new CarModel()
            {
                Name = "Ford Kuga",
                ProductionYear = 2015,
                HasIntelligentAWD = true
            };

            Console.WriteLine($"Application started from the new Main method! Model: {myCar.Name}");
        }
    }
}