using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Json;
using System.Text.Json;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.CustomModels;

namespace SchoolPortal.Web.Pages
{
    public class LoginModel : PageModel
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public LoginModel(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        [BindProperty]
        public required LoginDto LoginInput { get; set; }

        public string? ErrorMessage { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                var client = _httpClientFactory.CreateClient("ApiGateway");
                var response = await client.PostAsJsonAsync("api/userDetails/session", LoginInput);

                if (response.IsSuccessStatusCode)
                {
                    var sessionData = await response.Content.ReadFromJsonAsync<SessionModel>();
                    if (sessionData is not null)
                    {
                        HttpContext.Session.SetString("UserSession", JsonSerializer.Serialize(sessionData));
                        return RedirectToPage("/Index");
                    }
                }

                ErrorMessage = "Invalid username or password.";
                return Page();
            }
            catch (Exception)
            {
                ErrorMessage = "An error occurred while trying to log in. Please try again later.";
                return Page();
            }
        }
    }
} 