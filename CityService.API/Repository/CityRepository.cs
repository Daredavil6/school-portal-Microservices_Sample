using SchoolPortal.Common.Models.dboSchema;
using SchoolPortal.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace CityService.API.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly SchoolPortalContext _context;

        public CityRepository(SchoolPortalContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CityMaster?>> GetAllAsync()
        {
            return await _context.Set<CityMaster>().ToListAsync();
        }

        public async Task<CityMaster?> GetByIdAsync(Guid id)
        {
            return await _context.Set<CityMaster>().FindAsync(id);
        }

        public async Task<bool> CreateAsync(CityMaster city)
        {
            await _context.Set<CityMaster>().AddAsync(city);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Guid id, CityMaster? city)
        {
            var cityEntity = await _context.Set<CityMaster>().FindAsync(id);
            if (cityEntity == null) return false;

            _context.Set<CityMaster>().Update(cityEntity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var city = await _context.Set<CityMaster>().FindAsync(id);
            if (city == null) return false;

            _context.Set<CityMaster>().Remove(city);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
