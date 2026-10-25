using System;
using ProductCatalog.Library;

namespace ProductCatalog.TlsApp
{
    public class Startup
    {
        public static void Main(string[] args)
        {
            CarModel myCar = new CarModel("Ford Kuga", 2015);
            myCar.HasIntelligentAWD = true;
            
            Console.WriteLine($"Aplikacja uruchomiona z nowej metody Main! Model: {myCar.Name}");
        }
    }
}