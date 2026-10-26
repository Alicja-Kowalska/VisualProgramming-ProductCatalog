using Interfaces;

namespace ProductCatalog.Library.BO
{
    public class CarBrand : ICarBrand
    {
        public string Name { get; set; }
        public string CountryOfOrigin { get; set; }
        public int YearEstablished { get; set; }

        public override string ToString() => $"{Name} ({CountryOfOrigin}) - est. {YearEstablished}";
    }
}