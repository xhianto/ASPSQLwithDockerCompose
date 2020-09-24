using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.Models
{
    public class SQLLeveranciersRepository : ILeveranciersRepository
    {
        private readonly MVCTuinCentrumCoreContext context;
        public SQLLeveranciersRepository(MVCTuinCentrumCoreContext context)
        {
            this.context = context;
        }

        public async Task<Leverancier> Add(Leverancier leverancier)
        {
            context.Leveranciers.Add(leverancier);
            await context.SaveChangesAsync();
            return leverancier;
        }

        public async Task<Leverancier> Delete(int id)
        {
            Leverancier leverancier = await context.Leveranciers.FindAsync(id);
            if (leverancier != null)
            {
                context.Leveranciers.Remove(leverancier);
                await context.SaveChangesAsync();
            }
            return leverancier;
        }

        public async Task<Leverancier> GetLeverancier(int id)
        {
            return await context.Leveranciers.FindAsync(id);
        }

        public async Task<List<Leverancier>> GetLeveranciers()
        {
            return await context.Leveranciers.ToListAsync();
        }

        public async Task<Leverancier> Update(Leverancier gewijzigdeLeverancier)
        {
            var leverancier = context.Leveranciers.Attach(gewijzigdeLeverancier);
            leverancier.State = EntityState.Modified;
            await context.SaveChangesAsync();
            return gewijzigdeLeverancier;
        }
        public async Task<List<Leverancier>> GetLeveranciersMetPostNr(string postnr)
        {
            return await context.Leveranciers
                .Where(l => l.PostNr == postnr)
                .ToListAsync();
        }
    }
}
