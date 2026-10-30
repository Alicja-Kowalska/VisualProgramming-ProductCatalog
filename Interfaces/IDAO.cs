using System.Collections.Generic;

namespace Interfaces
{
    public interface IDAO
    {
        IEnumerable<IKennelClub> GetAllClubs();
        IEnumerable<IDogBreed> GetAllBreeds();
    }
}