using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.dboSchema;
using StateService.API.Service;

namespace StateService.API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StateController : ControllerBase
    {
        private readonly IStateService _StateService;

        public StateController(IStateService StateService)
        {
            _StateService = StateService;
        }

        // ✅ GET: api/v1/State/countries
        [HttpGet("countries")]
        public async Task<ActionResult<IEnumerable<StateMaster>>> GetCountries()
        {
            return Ok(await _StateService.GetAllAsync());
        }

        // ✅ GET: api/v1/State/{id}
        [HttpGet("State/{id}")]
        public async Task<ActionResult<StateMaster>> GetStateById(Guid id)
        {
            var State = await _StateService.GetByIdAsync(id);

            if (State == null)
                return NotFound($"State with ID {id} not found.");

            return Ok(State);
        }

        // ✅ POST: api/v1/State/State
        [HttpPost("State")]
        public async Task<ActionResult<StateMaster>> CreateState([FromBody] CreateStateDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid data.");

            var createdState = await _StateService.AddAsync(dto);
            return Ok(createdState);
        }

        // ✅ PUT: api/v1/State/State/{id}
        [HttpPut("State/{id}")]
        public async Task<IActionResult> UpdateState(Guid id, [FromBody] UpdateStateDto dto)
        {
            if (dto == null)
                return BadRequest("Invalid data.");

            var updated = await _StateService.UpdateAsync(id, dto);

            if (updated)
                return NoContent();

            return NotFound($"State with ID {id} not found.");
        }

        // ✅ DELETE: api/v1/State/State/{id}
        [HttpDelete("State/{id}")]
        public async Task<IActionResult> DeleteState(Guid id)
        {
            var deleted = await _StateService.DeleteAsync(id);

            if (deleted)
                return NoContent();

            return NotFound($"State with ID {id} not found.");
        }
    }
}
