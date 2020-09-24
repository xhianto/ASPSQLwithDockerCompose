using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTuinCentrumCore.Models
{
    public class SQLPlantenRepository : IPlantRepository
    {
        private readonly MVCTuinCentrumCoreContext context;
        public SQLPlantenRepository(MVCTuinCentrumCoreContext context)
        {
            this.context = context;
        }
        public async Task<Plant> Add(Plant plant)
        {
            context.Planten.Add(plant);
            await context.SaveChangesAsync();
            return plant;
        }

        public async Task<Plant> Delete(int id)
        {
            Plant plant = await context.Planten.FindAsync(id);
            if (plant != null)
            {
                context.Planten.Remove(plant);
                await context.SaveChangesAsync();
            }
            return plant;
        }

        public async Task<Plant> GetPlant(int? id)
        {
            return await context.Planten.FindAsync(id);
        }

        public async Task<List<Plant>> GetPlanten()
        {
            return await context.Planten.ToListAsync();
        }

        public async Task<Plant> Update(Plant gewijzigdePlant)
        {
            var plant = context.Planten.Attach(gewijzigdePlant);
            plant.State = EntityState.Modified;
            await context.SaveChangesAsync();
            return gewijzigdePlant;
        }
    }
}
