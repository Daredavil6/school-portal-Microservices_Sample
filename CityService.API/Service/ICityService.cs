using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.dboSchema;
using SchoolPortal.Common.Service;

namespace CityService.API.Service
{
    public interface ICityService : IGenericService<CityMaster, CreateCityDto, UpdateCityDto>
    {
        // Add any country-specific service methods here
    }
}