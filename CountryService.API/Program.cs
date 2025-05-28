using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models;
using CountryService.API.Repository;
using CountryService.API.Service;
using SchoolPortal.Common.Mappings;
using SchoolPortal.Common.Configuration;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add services to the container
builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpClient();

// ✅ Enable AutoMapper
builder.Services.AddAutoMapper(typeof(AutoMapperProfile));

// ✅ Register Swagger
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Country Service API",
        Version = "v1",
        Description = "API for managing country details"
    });
});

// ✅ Configure CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader());
});

// ✅ Add common connection string configuration
builder.Services.AddConnectionStrings(builder.Configuration);

// ✅ Configure DbContext with SQL Server
builder.Services.AddDbContext<SchoolPortalContext>(options =>
    options.UseSqlServer(ConnectionStrings.DefaultConnection));

// ✅ Register repository for DI
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICountryService, CountryService.API.Service.CountryService>();

var app = builder.Build();

// ✅ Configure middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/error");
    app.UseHsts();
}
else
{
    app.UseDeveloperExceptionPage();
}

// ✅ Use middleware
app.UseCors("AllowAll");
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Country Service API v1");
    c.RoutePrefix = "swagger";
});
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
