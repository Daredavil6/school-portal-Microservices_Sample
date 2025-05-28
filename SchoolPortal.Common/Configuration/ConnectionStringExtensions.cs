using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace SchoolPortal.Common.Configuration;

public static class ConnectionStringExtensions
{
    public static IServiceCollection AddConnectionStrings(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Configure all connection strings to use the default connection
        var connectionStrings = new ConnectionStrings();
        services.Configure<ConnectionStrings>(options =>
        {
            options.CompanyConnection = ConnectionStrings.DefaultConnection;
            options.CountryConnection = ConnectionStrings.DefaultConnection;
            options.StateConnection = ConnectionStrings.DefaultConnection;
            options.CityConnection = ConnectionStrings.DefaultConnection;
            options.UserDetailsConnection = ConnectionStrings.DefaultConnection;
        });
        
        return services;
    }

    public static string GetConnectionString(this IConfiguration configuration, string name)
    {
        // Always return the default connection string
        return ConnectionStrings.DefaultConnection;
    }

    public static string GetDefaultConnectionString()
    {
        return ConnectionStrings.DefaultConnection;
    }
} 