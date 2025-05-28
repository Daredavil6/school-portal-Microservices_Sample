using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;
using System.Text.Json;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.CustomModels;

namespace SchoolPortal.Web.Controllers;

[Route("Login")]
public class LoginController : Controller
{
	private readonly IHttpClientFactory _httpClientFactory;
	private readonly IConfiguration _configuration;

	public LoginController(IHttpClientFactory httpClientFactory, IConfiguration configuration)
	{
		_httpClientFactory = httpClientFactory;
		_configuration = configuration;
	}

	[HttpGet]
	public IActionResult Index()
	{
		return View(new LoginDto());
	}

	[HttpPost]
	[ValidateAntiForgeryToken]
	public async Task<IActionResult> Index([FromForm] LoginDto loginInput)
	{
		if (loginInput == null)
		{
			ModelState.AddModelError(string.Empty, "Login information is required.");
			return View(new LoginDto());
		}

		if (!ModelState.IsValid)
		{
			return View(loginInput);
		}

		try
		{
			var client = _httpClientFactory.CreateClient("ApiGateway");
			var response = await client.PostAsJsonAsync("api/v1/userdetails/session", loginInput);

			if (response.IsSuccessStatusCode)
			{
				var sessionData = await response.Content.ReadFromJsonAsync<SessionModel>();
				if (sessionData is not null)
				{
					HttpContext.Session.SetString("UserSession", JsonSerializer.Serialize(sessionData));
					return RedirectToAction("Index", "Home");
				}
			}

			ModelState.AddModelError(string.Empty, "Invalid username or password.");
			return View(loginInput);
		}
		catch (Exception)
		{
			ModelState.AddModelError(string.Empty, "An error occurred while trying to log in. Please try again later.");
			return View(loginInput);
		}
	}
} 