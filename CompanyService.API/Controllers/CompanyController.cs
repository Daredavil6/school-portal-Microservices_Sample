using CompanyService.API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.dboSchema;

namespace CompanyService.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _CompanyService;

        public CompanyController(ICompanyService CompanyService)
        {
            _CompanyService = CompanyService;
        }

        // ✅ GET: api/v1/Company/countries
        [HttpGet("countries")]
        public async Task<ActionResult<IEnumerable<CompanyMaster>>> GetCountries()
        {
            return Ok(await _CompanyService.GetAllAsync());
        }

        // ✅ GET: api/v1/Company/{id}
        [HttpGet("Company/{id}")]
        public async Task<ActionResult<CompanyMaster>> GetCompanyById(Guid id)
        {
            var Company = await _CompanyService.GetByIdAsync(id);

            if (Company == null)
                return NotFound($"Company with ID {id} not found.");

            return Ok(Company);
        }

        // ✅ POST: api/v1/Company/Company
        [HttpPost("Company")]
        public async Task<ActionResult<CompanyMaster>> CreateCompany([FromBody] CreateCompanyDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid data.");

            var createdCompany = await _CompanyService.AddAsync(dto);
            return Ok(createdCompany);
        }

        // ✅ PUT: api/v1/Company/Company/{id}
        [HttpPut("Company/{id}")]
        public async Task<IActionResult> UpdateCompany(Guid id, [FromBody] UpdateCompanyDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid data.");

            var updated = await _CompanyService.UpdateAsync(id, dto);

            if (updated)
                return NoContent();

            return NotFound($"Company with ID {id} not found.");
        }

        // ✅ DELETE: api/v1/Company/Company/{id}
        [HttpDelete("Company/{id}")]
        public async Task<IActionResult> DeleteCompany(Guid id)
        {
            var deleted = await _CompanyService.DeleteAsync(id);

            if (deleted)
                return NoContent();

            return NotFound($"Company with ID {id} not found.");
        }
    }
}
