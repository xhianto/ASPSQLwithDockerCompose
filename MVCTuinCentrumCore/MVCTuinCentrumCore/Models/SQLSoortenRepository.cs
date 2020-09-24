using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.Models
{
    public class SQLSoortenRepository : ISoortenRepository
    {
        private readonly MVCTuinCentrumCoreContext context;
        public SQLSoortenRepository(MVCTuinCentrumCoreContext context)
        {
            this.context = context;
        }

        public async Task<Soort> Add(Soort soort)
        {
            context.Soorten.Add(soort);
            await context.SaveChangesAsync();
            return soort;
        }

        public async Task<Soort> Delete(int id)
        {
            Soort soort = await context.Soorten.FindAsync(id);
            if (soort != null)
            {
                context.Soorten.Remove(soort);
                await context.SaveChangesAsync();
            }
            return soort;
        }


        public async Task<Soort> GetSoort(int? id)
        {
            return await context.Soorten.FindAsync(id);
        }

        public async Task<List<Soort>> GetSoorten()
        {
            return await context.Soorten.ToListAsync();
        }

        public async Task<Soort> Update(Soort gewijzigdeSoort)
        {
            var soort = context.Soorten.Attach(gewijzigdeSoort);
            soort.State = EntityState.Modified;
            await context.SaveChangesAsync();
            return gewijzigdeSoort;
        }
        public async Task<List<Soort>> FingByBeginNaam(string beginNaam)
        {
            return await (from soort in context.Soorten
                          where soort.Naam.StartsWith(beginNaam)
                          select soort).ToListAsync();
        }
    }
}
