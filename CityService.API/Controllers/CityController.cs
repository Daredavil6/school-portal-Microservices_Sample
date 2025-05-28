using CityService.API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.dboSchema;

namespace CityService.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _CityService;

        public CityController(ICityService CityService)
        {
            _CityService = CityService;
        }

        // ✅ GET: api/v1/City/countries
        [HttpGet("countries")]
        public async Task<ActionResult<IEnumerable<CityMaster>>> GetCountries()
        {
            return Ok(await _CityService.GetAllAsync());
        }

        // ✅ GET: api/v1/City/{id}
        [HttpGet("City/{id}")]
        public async Task<ActionResult<CityMaster>> GetCityById(Guid id)
        {
            var City = await _CityService.GetByIdAsync(id);

            if (City == null)
                return NotFound($"City with ID {id} not found.");

            return Ok(City);
        }

        // ✅ POST: api/v1/City/City
        [HttpPost("City")]
        public async Task<ActionResult<CityMaster>> CreateCity([FromBody] CreateCityDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid data.");

            var createdCity = await _CityService.AddAsync(dto);
            return Ok(createdCity);
        }

        // ✅ PUT: api/v1/City/City/{id}
        [HttpPut("City/{id}")]
        public async Task<IActionResult> UpdateCity(Guid id, [FromBody] UpdateCityDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid data.");

            var updated = await _CityService.UpdateAsync(id, dto);

            if (updated)
                return NoContent();

            return NotFound($"City with ID {id} not found.");
        }

        // ✅ DELETE: api/v1/City/City/{id}
        [HttpDelete("City/{id}")]
        public async Task<IActionResult> DeleteCity(Guid id)
        {
            var deleted = await _CityService.DeleteAsync(id);

            if (deleted)
                return NoContent();

            return NotFound($"City with ID {id} not found.");
        }
    }
}
