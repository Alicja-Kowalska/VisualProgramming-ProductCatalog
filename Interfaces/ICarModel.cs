namespace Interfaces
{
    public interface ICarModel
    {
        string Name { get; set; }
        EngineTypeEnum EngineType { get; set; }
        bool HasIntelligentAWD { get; set; }
        int ProductionYear { get; set; }
    }
}