using System;
using Interfaces;
using ProductCatalog.Library.DAO;

IDAO database = new MockDAO();

Console.WriteLine("--- CAR BRANDS ---");
foreach (ICarBrand brand in database.GetAllBrands())
{
    Console.WriteLine(brand.ToString());
}

Console.WriteLine("\n--- CAR MODELS ---");
foreach (ICarModel model in database.GetAllModels())
{
    Console.WriteLine(model.ToString());
}