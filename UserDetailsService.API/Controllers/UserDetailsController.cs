using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.CustomModels;
using SchoolPortal.Common.Models.dboSchema;
using UserDetailsService.API.Service;

namespace UserDetailsService.API.Controllers
{
	[Route("api/v1/[controller]")]
	[ApiController]
	public class UserDetailsController : ControllerBase
	{
		private readonly IUserDetailsService _userDetailsService;

		public UserDetailsController(IUserDetailsService userDetailsService)
		{
			_userDetailsService = userDetailsService;
		}

		// ✅ GET: api/v1/userDetails/userDetails
		[HttpGet("userDetails")]
		public async Task<ActionResult<IEnumerable<UserDetail>>> GetUserDetails()
		{
			return Ok(await _userDetailsService.GetAllAsync());
		}

		// ✅ GET: api/v1/userDetails/{id}
		[HttpGet("userDetails/{id}")]
		public async Task<ActionResult<UserDetail>> GetuserDetailsById(Guid id)
		{
			var userDetails = await _userDetailsService.GetByIdAsync(id);

			if (userDetails == null)
				return NotFound($"userDetails with ID {id} not found.");

			return Ok(userDetails);
		}

		// ✅ POST: api/v1/userDetails/userDetails
		[HttpPost("userDetails")]
		public async Task<ActionResult<UserDetail>> CreateuserDetails([FromBody] CreateUserDetailDto dto)
		{
			if (dto == null)
				return BadRequest("Invalid data.");

			var createduserDetails = await _userDetailsService.AddAsync(dto);
			return Ok(createduserDetails);
		}

		// ✅ PUT: api/v1/userDetails/userDetails/{id}
		[HttpPut("userDetails/{id}")]
		public async Task<IActionResult> UpdateuserDetails(Guid id, [FromBody] UpdateUserDetailDto dto)
		{
			if (dto == null)
				return BadRequest("Invalid data.");

			var updated = await _userDetailsService.UpdateAsync(id, dto);

			if (updated)
				return NoContent();

			return NotFound($"userDetails with ID {id} not found.");
		}

		// ✅ DELETE: api/v1/userDetails/userDetails/{id}
		[HttpDelete("userDetails/{id}")]
		public async Task<IActionResult> DeleteuserDetails(Guid id)
		{
			var deleted = await _userDetailsService.DeleteAsync(id);

			if (deleted)
				return NoContent();

			return NotFound($"userDetails with ID {id} not found.");
		}

		// ✅ POST: api/userDetails/authenticate
		[HttpPost("authenticate")]
		public async Task<IActionResult> AuthenticateUser([FromBody] LoginDto login)
		{
			if (string.IsNullOrEmpty(login.UserName) || string.IsNullOrEmpty(login.UserPassword))
				return BadRequest("Username and password are required.");

			bool isValid = await _userDetailsService.AuthenticateUser(login.UserName, login.UserPassword);

			if (!isValid)
				return Unauthorized("Invalid username or password.");

			return Ok("Authentication successful.");
		}

		// ✅ POST: api/userDetails/session
		[HttpPost("session")]
		public async Task<ActionResult<SessionModel>> GetUserSession([FromBody] LoginDto login)
		{
			if (string.IsNullOrEmpty(login.UserName) || string.IsNullOrEmpty(login.UserPassword))
				return BadRequest("Username and password are required.");

			var session = await _userDetailsService.GetUserSession(login.UserName, login.UserPassword);

			if (session?.userDetail == null)
				return Unauthorized("Invalid credentials.");

			return Ok(session);
		}
	}
}
