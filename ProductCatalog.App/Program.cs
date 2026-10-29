using System;
using System.Configuration;
using Interfaces;
using ProductCatalog.BLC;

string libraryName = ConfigurationManager.AppSettings["LibraryName"];

BusinessLogic logic = BusinessLogic.GetInstance(libraryName);

Console.WriteLine("--- CAR BRANDS ---");
foreach (ICarBrand brand in logic.Database.GetAllBrands())
{
    Console.WriteLine(brand.ToString());
}

Console.WriteLine("\n--- CAR MODELS ---");
foreach (ICarModel model in logic.Database.GetAllModels())
{
    Console.WriteLine(model.ToString());
}