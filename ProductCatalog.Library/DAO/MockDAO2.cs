using System.Collections.Generic;
using Interfaces;
using ProductCatalog.Library.BO;

namespace ProductCatalog.Library.DAO
{
    public class MockDAO2 : IDAO
    {
        private List<IKennelClub> _clubs;
        private List<IDogBreed> _breeds;

        public MockDAO2()
        {
            _clubs = new List<IKennelClub>
            {
                new KennelClub { Name = "The Kennel Club", CountryOfOrigin = "United Kingdom", YearEstablished = 1873 },
                new KennelClub { Name = "CKC (Canadian Kennel Club)", CountryOfOrigin = "Canada", YearEstablished = 1888 },
                new KennelClub { Name = "ANKC (Australian National Kennel Council)", CountryOfOrigin = "Australia", YearEstablished = 1958 }
            };

            _breeds = new List<IDogBreed>
            {
                new DogBreed { Name = "Australian Shepherd", Group = BreedGroupEnum.Herding, IsHypoallergenic = false, AverageLifespan = 14 },
                new DogBreed { Name = "Boxer", Group = BreedGroupEnum.Working, IsHypoallergenic = false, AverageLifespan = 11 },
                new DogBreed { Name = "Saint Bernard", Group = BreedGroupEnum.Working, IsHypoallergenic = false, AverageLifespan = 9 },
                new DogBreed { Name = "Labrador Retriever", Group = BreedGroupEnum.Sporting, IsHypoallergenic = false, AverageLifespan = 12 },
                new DogBreed { Name = "Cocker Spaniel", Group = BreedGroupEnum.Sporting, IsHypoallergenic = false, AverageLifespan = 13 },
                new DogBreed { Name = "Bull Terrier", Group = BreedGroupEnum.Terrier, IsHypoallergenic = false, AverageLifespan = 12 },
                new DogBreed { Name = "Chihuahua", Group = BreedGroupEnum.Toy, IsHypoallergenic = false, AverageLifespan = 16 },
                new DogBreed { Name = "Shih Tzu", Group = BreedGroupEnum.Toy, IsHypoallergenic = true, AverageLifespan = 14 }
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