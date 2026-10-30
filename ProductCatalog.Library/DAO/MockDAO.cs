using System.Collections.Generic;
using Interfaces;
using ProductCatalog.Library.BO;

namespace ProductCatalog.Library.DAO
{
    public class MockDAO : IDAO
    {
        private List<IKennelClub> _clubs;
        private List<IDogBreed> _breeds;

        public MockDAO()
        {
            _clubs = new List<IKennelClub>
            {
                new KennelClub { Name = "FCI (Fédération Cynologique Internationale)", CountryOfOrigin = "Belgium", YearEstablished = 1911 },
                new KennelClub { Name = "AKC (American Kennel Club)", CountryOfOrigin = "USA", YearEstablished = 1884 },
                new KennelClub { Name = "ZKwP (Związek Kynologiczny w Polsce)", CountryOfOrigin = "Poland", YearEstablished = 1938 }
            };

            _breeds = new List<IDogBreed>
            {
                new DogBreed { Name = "Border Collie", Group = BreedGroupEnum.Herding, IsHypoallergenic = false, AverageLifespan = 13 },
                new DogBreed { Name = "German Shepherd", Group = BreedGroupEnum.Herding, IsHypoallergenic = false, AverageLifespan = 11 },
                new DogBreed { Name = "Poodle (Standard)", Group = BreedGroupEnum.Toy, IsHypoallergenic = true, AverageLifespan = 14 },
                new DogBreed { Name = "Rottweiler", Group = BreedGroupEnum.Working, IsHypoallergenic = false, AverageLifespan = 10 },
                new DogBreed { Name = "Doberman Pinscher", Group = BreedGroupEnum.Working, IsHypoallergenic = false, AverageLifespan = 11 },
                new DogBreed { Name = "Golden Retriever", Group = BreedGroupEnum.Sporting, IsHypoallergenic = false, AverageLifespan = 12 },
                new DogBreed { Name = "Jack Russell Terrier", Group = BreedGroupEnum.Terrier, IsHypoallergenic = false, AverageLifespan = 14 },
                new DogBreed { Name = "Yorkshire Terrier", Group = BreedGroupEnum.Terrier, IsHypoallergenic = true, AverageLifespan = 15 }
            };
        }

        public IEnumerable<IKennelClub> GetAllClubs()
        {
            return _clubs;
        }

        public IEnumerable<IDogBreed> GetAllBreeds()
        {
            return _breeds;
        }
    }
}