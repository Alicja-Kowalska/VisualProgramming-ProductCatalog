using System.Collections.Generic;
using Interfaces;
using ProductCatalog.Library.BO;

namespace ProductCatalog.Library.DAO
{
    public class MockDAO : IDAO
    {
        private List<ICarBrand> brands;
        private List<ICarModel> models;

        public MockDAO()
        {
            // Mock data for demonstration purposes
            brands = new List<ICarBrand>()
            {
                new CarBrand { Name = "Ford", CountryOfOrigin = "USA", YearEstablished = 1903 },
                new CarBrand { Name = "Toyota", CountryOfOrigin = "Japan", YearEstablished = 1937 }
            };

            models = new List<ICarModel>()
            {
                new CarModel { Name = "Kuga", EngineType = EngineTypeEnum.Combustion, HasIntelligentAWD = true, ProductionYear = 2015 },
                new CarModel { Name = "RAV4", EngineType = EngineTypeEnum.Hybrid, HasIntelligentAWD = true, ProductionYear = 2023 }
            };
        }

        // Returning collections as IEnumerable instead of fixed arrays
        public IEnumerable<ICarBrand> GetAllBrands() => brands;
        public IEnumerable<ICarModel> GetAllModels() => models;
    }
}