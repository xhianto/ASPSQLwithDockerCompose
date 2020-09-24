using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.Models
{
    public interface IPlantRepository
    {
        Task<Plant> GetPlant(int? id);
        Task<List<Plant>> GetPlanten();
        Task<Plant> Add(Plant Plant);
        Task<Plant> Update(Plant gewijzigdePlant);
        Task<Plant> Delete(int id);
    }
}
