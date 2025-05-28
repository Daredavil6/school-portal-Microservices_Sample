using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models;
using StateService.API.Repository;
using StateService.API.Service;
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
        Title = "State Service API",
        Version = "v1",
        Description = "API for managing state details"
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
builder.Services.AddScoped<IStateRepository, StateRepository>();
builder.Services.AddScoped<IStateService, StateService.API.Service.StateService>();

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
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "State Service API v1");
});
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
