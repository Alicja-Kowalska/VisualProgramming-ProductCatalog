namespace Interfaces
{
    public interface IDogBreed
    {
        string? Name { get; set; }
        BreedGroupEnum Group { get; set; }
        bool IsHypoallergenic { get; set; }
        int AverageLifespan { get; set; }
    }
}