using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models;
using SchoolPortal.Common.Models.dboSchema;
using SchoolPortal.Common.Service;

namespace CountryService.API.Service
{
	public interface ICountryService : IGenericService<CountryMaster, CreateCountryDto, UpdateCountryDto>
	{
		// Add any country-specific service methods here
	}
}
