using CountryService.API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models;
using SchoolPortal.Common.Models.dboSchema;

namespace CountryService.API.Controllers
{

	[Route("api/v1/[controller]")]
	[ApiController]
	public class CountryController : ControllerBase
	{
		private readonly ICountryService _countryService;

		public CountryController(ICountryService countryService)
		{
			_countryService = countryService;
		}

		// ✅ GET: api/v1/country/countries
		[HttpGet("countries")]
		public async Task<ActionResult<IEnumerable<CountryMaster>>> GetCountries()
		{
			return Ok(await _countryService.GetAllAsync());
		}

		// ✅ GET: api/v1/country/{id}
		[HttpGet("country/{id}")]
		public async Task<ActionResult<CountryMaster>> GetCountryById(Guid id)
		{
			var country = await _countryService.GetByIdAsync(id);

			if (country == null)
				return NotFound($"Country with ID {id} not found.");

			return Ok(country);
		}

		// ✅ POST: api/v1/country/country
		[HttpPost("country")]
		public async Task<ActionResult<CountryMaster>> CreateCountry([FromBody] CreateCountryDto dto)
		{
			if (dto == null)
				return BadRequest("Invalid data.");

			var createdCountry = await _countryService.AddAsync(dto);
			return Ok(createdCountry);
		}

		// ✅ PUT: api/v1/country/country/{id}
		[HttpPut("country/{id}")]
		public async Task<IActionResult> UpdateCountry(Guid id, [FromBody] UpdateCountryDto dto)
		{
			if (dto == null)
				return BadRequest("Invalid data.");

			var updated = await _countryService.UpdateAsync(id, dto);

			if (updated)
				return NoContent();

			return NotFound($"Country with ID {id} not found.");
		}

		// ✅ DELETE: api/v1/country/country/{id}
		[HttpDelete("country/{id}")]
		public async Task<IActionResult> DeleteCountry(Guid id)
		{
			var deleted = await _countryService.DeleteAsync(id);

			if (deleted)
				return NoContent();

			return NotFound($"Country with ID {id} not found.");
		}
	}
}
