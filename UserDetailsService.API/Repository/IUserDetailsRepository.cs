using SchoolPortal.Common.Models;
using SchoolPortal.Common.Models.CustomModels;
using SchoolPortal.Common.Models.dboSchema;
using SchoolPortal.Common.Repository;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;


namespace UserDetailsService.API.Repository
{
    public interface IUserDetailsRepository : IGenericRepository<UserDetail>
    {
        public Task<bool> AuthenticateUser(string userName, string password);
        public Task<SessionModel> GetUserSession(string userName, string password);
    }
}
