using AutoMapper;
using CompanyService.API.Repository;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.dboSchema;

namespace CompanyService.API.Service
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _CompanyRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository CompanyRepository, IMapper mapper)
        {
            _CompanyRepository = CompanyRepository;
            _mapper = mapper;
        }

        public async Task<CompanyMaster?> AddAsync(CreateCompanyDto dto)
        {
            var Company = _mapper.Map<CompanyMaster>(dto);

            await _CompanyRepository.CreateAsync(Company);

            return _mapper.Map<CompanyMaster?>(Company);  // 🔥 Return the newly created Company DTO
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var success = await _CompanyRepository.DeleteAsync(id); // Delete the company by ID
            if (!success)
            {
                throw new InvalidOperationException("Failed to delete Company"); // Handle failure
            }
            return true;  // Return true if deletion was successful
        }

        public async Task<IEnumerable<CompanyMaster?>> GetAllAsync()
        {
            return await _CompanyRepository.GetAllAsync();
        }

        public async Task<CompanyMaster?> GetByIdAsync(Guid id)
        {
            var company = await _CompanyRepository.GetByIdAsync(id);
            return company == null ? null : _mapper.Map<CompanyMaster?>(company);
        }

        public async Task<bool> UpdateAsync(Guid id, UpdateCompanyDto dto)
        {
            var company = await _CompanyRepository.GetByIdAsync(id);

            if (company == null)
                return false;

            _mapper.Map(dto, company);
            return await _CompanyRepository.UpdateAsync(id, company);
        }
    }
}