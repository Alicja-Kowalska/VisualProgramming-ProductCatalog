using System.Collections.Generic;

namespace Interfaces
{
    public interface IDAO
    {
        IEnumerable<ICarBrand> GetAllBrands();
        IEnumerable<ICarModel> GetAllModels();
    }
}