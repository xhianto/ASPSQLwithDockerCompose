using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.Models
{
    public interface ILeveranciersRepository
    {
        Task<Leverancier> GetLeverancier(int id);
        Task<List<Leverancier>> GetLeveranciers();
        Task<Leverancier> Add(Leverancier leverancier);
        Task<Leverancier> Update(Leverancier gewijzigdeLeverancier);
        Task<Leverancier> Delete(int id);
        Task<List<Leverancier>> GetLeveranciersMetPostNr(string postnr);
    }
}
