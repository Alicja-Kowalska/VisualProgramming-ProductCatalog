using Interfaces;

namespace ProductCatalog.Library.BO
{
    public class CarModel : ICarModel
    {
        public string Name { get; set; }
        public EngineTypeEnum EngineType { get; set; } // Using the new enumeration type
        public bool HasIntelligentAWD { get; set; }
        public int ProductionYear { get; set; }

        public override string ToString() => $"{Name} ({ProductionYear}) - Drive: {EngineType}, AWD: {HasIntelligentAWD}";
    }
}