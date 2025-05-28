using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.CustomModels;
using SchoolPortal.Common.Models.dboSchema;
using SchoolPortal.Common.Service;

namespace UserDetailsService.API.Service
{
    public interface IUserDetailsService : IGenericService<UserDetail, CreateUserDetailDto, UpdateUserDetailDto>
    {
        public Task<bool> AuthenticateUser(string userName, string password);
        public Task<SessionModel> GetUserSession(string userName, string password);
    }
}
