using System;
using System.Configuration;
using Interfaces;
using ProductCatalog.BLC;

// Read the library name from App.config
string libraryName = ConfigurationManager.AppSettings["LibraryName"];

// Initialize Singleton and dynamically load the database
BusinessLogic logic = BusinessLogic.GetInstance(libraryName);

Console.WriteLine("--- CAR BRANDS (LOADED DYNAMICALLY) ---");
foreach (ICarBrand brand in logic.Database.GetAllBrands())
{
    Console.WriteLine(brand.ToString());
}

Console.WriteLine("\n--- CAR MODELS (LOADED DYNAMICALLY) ---");
foreach (ICarModel model in logic.Database.GetAllModels())
{
    Console.WriteLine(model.ToString());
}