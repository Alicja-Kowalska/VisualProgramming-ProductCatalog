using Interfaces;

namespace ProductCatalog.Library.BO
{
    public class KennelClub : IKennelClub
    {
        public string? Name { get; set; }
        public string? CountryOfOrigin { get; set; }
        public int YearEstablished { get; set; }

        public override string ToString()
        {
            return $"{Name} ({CountryOfOrigin}) - est. {YearEstablished}";
        }
    }
}