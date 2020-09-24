using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.Models
{
    public interface ISoortenRepository
    {
        Task<Soort> GetSoort(int? id);
        Task<List<Soort>> GetSoorten();
        Task<Soort> Add(Soort soort);
        Task<Soort> Update(Soort gewijzigdeSoort);
        Task<Soort> Delete(int id);
        Task<List<Soort>> FingByBeginNaam(string beginNaam);
    }
}
