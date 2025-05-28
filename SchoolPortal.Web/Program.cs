using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Add MVC support (this line is missing in your code)
builder.Services.AddControllersWithViews();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddHttpClient("ApiGateway", client =>
{
	client.BaseAddress = new Uri("https://localhost:5001"); // Update with your API Gateway URL
});

// Add session support
builder.Services.AddSession(options =>
{
	options.IdleTimeout = TimeSpan.FromMinutes(30);
	options.Cookie.HttpOnly = true;
	options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Routing
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Login}/{action=Index}/{id?}");

// Use session middleware
app.UseSession();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
