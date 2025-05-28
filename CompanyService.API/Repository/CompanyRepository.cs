using SchoolPortal.Common.Models.dboSchema;
using SchoolPortal.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace CompanyService.API.Repository
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly SchoolPortalContext _context;

        public CompanyRepository(SchoolPortalContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CompanyMaster?>> GetAllAsync()
        {
            return await _context.Set<CompanyMaster>().ToListAsync();
        }

        public async Task<CompanyMaster?> GetByIdAsync(Guid id)
        {
            return await _context.Set<CompanyMaster>().FindAsync(id);
        }

        public async Task<bool> CreateAsync(CompanyMaster company)
        {
            await _context.Set<CompanyMaster>().AddAsync(company);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(Guid id, CompanyMaster? company)
        {
            var companyEntity = await _context.Set<CompanyMaster>().FindAsync(id);
            if (companyEntity == null) return false;

            _context.Set<CompanyMaster>().Update(companyEntity);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var Company = await _context.Set<CompanyMaster>().FindAsync(id);
            if (Company == null) return false;

            _context.Set<CompanyMaster>().Remove(Company);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
