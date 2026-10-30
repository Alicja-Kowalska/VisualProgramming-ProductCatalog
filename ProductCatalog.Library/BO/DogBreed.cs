using Interfaces;

namespace ProductCatalog.Library.BO
{
    public class DogBreed : IDogBreed
    {
        public string? Name { get; set; }
        public BreedGroupEnum Group { get; set; }
        public bool IsHypoallergenic { get; set; }
        public int AverageLifespan { get; set; }

        public override string ToString()
        {
            return $"{Name} (Lifespan: {AverageLifespan} yrs) - Group: {Group}, Hypoallergenic: {IsHypoallergenic}";
        }
    }
}