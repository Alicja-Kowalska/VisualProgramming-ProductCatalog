using ProductCatalog.Library;

CarModel myCar = new CarModel();
myCar.Name = "Ford Kuga";
myCar.ProductionYear = 2015;
myCar.HasIntelligentAWD = true;

Console.WriteLine($"Dodano do katalogu: {myCar.Name} ({myCar.ProductionYear}), napęd AWD: {myCar.HasIntelligentAWD}");