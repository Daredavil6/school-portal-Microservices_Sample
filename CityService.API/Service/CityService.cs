using AutoMapper;
using CityService.API.Repository;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.dboSchema;

namespace CityService.API.Service
{
	public class CityService : ICityService
	{
		private readonly ICityRepository _CityRepository;
		private readonly IMapper _mapper;

		public CityService(ICityRepository CityRepository, IMapper mapper)
		{
			_CityRepository = CityRepository;
			_mapper = mapper;
		}

		public async Task<CityMaster?> AddAsync(CreateCityDto dto)
		{
			var City = _mapper.Map<CityMaster>(dto);

			await _CityRepository.CreateAsync(City);

			return _mapper.Map<CityMaster?>(City);  // 🔥 Return the newly created City DTO
		}

		public async Task<bool> DeleteAsync(Guid id)
		{
			var success = await _CityRepository.DeleteAsync(id); // Delete the company by ID
			if (!success)
			{
				throw new InvalidOperationException("Failed to delete City"); // Handle failure
			}
			return true;  // Return true if deletion was successful
		}

		public async Task<IEnumerable<CityMaster?>> GetAllAsync()
		{
			return await _CityRepository.GetAllAsync();
		}

		public async Task<CityMaster?> GetByIdAsync(Guid id)
		{
			var City = await _CityRepository.GetByIdAsync(id);
			return City == null ? null : _mapper.Map<CityMaster?>(City);
		}

		public async Task<bool> UpdateAsync(Guid id, UpdateCityDto dto)
		{
			var City = await _CityRepository.GetByIdAsync(id);

			if (City == null) 
				return false;

			_mapper.Map(dto, City);
			return await _CityRepository.UpdateAsync(id, City);
		}
	}
}