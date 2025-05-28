using SchoolPortal.Common.Models;
using SchoolPortal.Common.Models.dboSchema;
using SchoolPortal.Common.Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CountryService.API.Repository
{
    public interface ICountryRepository : IGenericRepository<CountryMaster>
    {
        // Add any company-specific repository methods here
    }
}
