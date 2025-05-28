using AutoMapper;
using CountryService.API.Repository;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models;
using SchoolPortal.Common.Models.dboSchema;
using SchoolPortal.Common.Service;
using System.Diagnostics.Metrics;

namespace CountryService.API.Service
{
	public class CountryService : ICountryService
	{
		private readonly ICountryRepository _countryRepository;
		private readonly IMapper _mapper;

		public CountryService(ICountryRepository countryRepository, IMapper mapper)
		{
			_countryRepository = countryRepository;
			_mapper = mapper;
		}

		public async Task<CountryMaster?> AddAsync(CreateCountryDto dto)
		{
			var country = _mapper.Map<CountryMaster>(dto);

			await _countryRepository.CreateAsync(country);

			return _mapper.Map<CountryMaster?>(country);  // 🔥 Return the newly created country DTO
		}

		public async Task<bool> DeleteAsync(Guid id)
		{
			var success = await _countryRepository.DeleteAsync(id); // Delete the company by ID
			if (!success)
			{
				throw new InvalidOperationException("Failed to delete country"); // Handle failure
			}
			return true;  // Return true if deletion was successful
		}

		public async Task<IEnumerable<CountryMaster?>> GetAllAsync()
		{
			return await _countryRepository.GetAllAsync();
		}

		public async Task<CountryMaster?> GetByIdAsync(Guid id)
		{
			var country = await _countryRepository.GetByIdAsync(id);
			return country == null ? null : _mapper.Map<CountryMaster?>(country);
		}

		public async Task<bool> UpdateAsync(Guid id, UpdateCountryDto dto)
		{
			var country = await _countryRepository.GetByIdAsync(id);

			if (country == null) return false;

			_mapper.Map(dto, country);

			return await _countryRepository.UpdateAsync(id, country);
		}


	}
}
