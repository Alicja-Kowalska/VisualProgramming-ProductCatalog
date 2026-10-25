namespace ProductCatalog.Library
{
    public class CarModel
    {
        public string Name;          // np. "Kuga"
        public string EngineType;    // np. "2.0 TDCi"
        public bool HasIntelligentAWD; // np. true
        public int ProductionYear;   // np. 2015

        public CarModel(string name, int productionYear)
        {
            Name = name;
            ProductionYear = productionYear;
        }
    }
}