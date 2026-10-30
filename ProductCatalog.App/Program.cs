using System;
using System.Configuration;
using Interfaces;
using ProductCatalog.BLC;

string libraryName = ConfigurationManager.AppSettings["LibraryName"]
                     ?? throw new Exception("Set LibraryName in configuration");
IDAO logic = BusinessLogic.GetInstance(libraryName);

Console.WriteLine("--- KENNEL CLUBS ---");
Console.WriteLine(string.Join(Environment.NewLine, logic.GetAllClubs()));

Console.WriteLine("\n--- DOG BREEDS ---");
Console.WriteLine(string.Join(Environment.NewLine, logic.GetAllBreeds()));