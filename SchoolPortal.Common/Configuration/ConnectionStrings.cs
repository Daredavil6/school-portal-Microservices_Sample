namespace SchoolPortal.Common.Configuration;

public class ConnectionStrings
{
    public const string DefaultConnection = "Data Source=SAGAR\\SQL2022;Initial Catalog=SchoolPortal;Integrated Security=True;Trust Server Certificate=True;Command Timeout=300";
    
    // For backward compatibility and future extensibility
    public string CompanyConnection { get; set; } = DefaultConnection;
    public string CountryConnection { get; set; } = DefaultConnection;
    public string StateConnection { get; set; } = DefaultConnection;
    public string CityConnection { get; set; } = DefaultConnection;
    public string UserDetailsConnection { get; set; } = DefaultConnection;
} 