using SchoolPortal.Common.Models.dboSchema;
using SchoolPortal.Common.Models;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.CustomModels;

namespace UserDetailsService.API.Repository
{
	public class UserDetailsRepository : IUserDetailsRepository
	{
		private readonly SchoolPortalContext _context;

		public UserDetailsRepository(SchoolPortalContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<UserDetail?>> GetAllAsync()
		{
			return await _context.Set<UserDetail>().ToListAsync();
		}

		public async Task<UserDetail?> GetByIdAsync(Guid id)
		{
			return await _context.Set<UserDetail>().FindAsync(id);
		}

		public async Task<bool> CreateAsync(UserDetail Country)
		{
			await _context.Set<UserDetail>().AddAsync(Country);
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<bool> UpdateAsync(Guid id, UserDetail? Country)
		{
			var CountryEntity = await _context.Set<UserDetail>().FindAsync(id);
			if (CountryEntity == null) return false;

			_context.Set<UserDetail>().Update(CountryEntity);
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<bool> DeleteAsync(Guid id)
		{
			var Country = await _context.Set<UserDetail>().FindAsync(id);
			if (Country == null) return false;

			_context.Set<UserDetail>().Remove(Country);
			return await _context.SaveChangesAsync() > 0;
		}

		public async Task<bool> AuthenticateUser(string userName, string password)
		{
			var user = await _context.Set<UserDetail>()
				.FirstOrDefaultAsync(u => u.UserName == userName && u.UserPassword == password && u.IsActive == true);
			return user != null;
		}
		public async Task<SessionModel> GetUserSession(string userName, string password)
		{
			SessionModel sessionModel = new SessionModel();

			var user = await _context.Set<UserDetail>()
				.FirstOrDefaultAsync(u => u.UserName == userName && u.UserPassword == password && u.IsActive == true);

			if (user != null)
			{
				sessionModel.userDetail = user;

				var role = await _context.RoleMasters
					.FirstOrDefaultAsync(r => r.Id == user.UserRoleId);
				sessionModel.userRole = role?.RoleMasterName;

				var designation = await _context.DesigMasters
					.FirstOrDefaultAsync(d => d.Id == user.DesignationId);
				sessionModel.userDesignation = designation?.Name;

				if (user.UserRoleId.HasValue)
				{
					var privilegeNames = await (from rp in _context.RolePrivileges
												join p in _context.Privileges on rp.PrivilegeId equals p.Id
												join rl in _context.RoleMasters on rp.RoleId equals rl.Id
												where rp.IsActive == true && rp.IsDeleted == false && rp.RoleId == user.UserRoleId
												select p.PrivilegeName).ToListAsync();

					sessionModel.userPrivileges = privilegeNames;
				}
			}
			return sessionModel;
		}
	}
}
