using System.Collections.Generic;
using Interfaces;
using ProductCatalog.Library.BO;

namespace ProductCatalog.Library.DAO
{
    public class MockDAO2 : IDAO
    {
        private List<ICarBrand> brands;
        private List<ICarModel> models;

        public MockDAO2()
        {
            brands = new List<ICarBrand>()
            {
                new CarBrand { Name = "Porsche", CountryOfOrigin = "Germany", YearEstablished = 1931 }
            };

            models = new List<ICarModel>()
            {
                new CarModel { Name = "911 Carrera", EngineType = EngineTypeEnum.Combustion, HasIntelligentAWD = false, ProductionYear = 2024 }
            };
        }

        public IEnumerable<ICarBrand> GetAllBrands() => brands;
        public IEnumerable<ICarModel> GetAllModels() => models;
    }
}