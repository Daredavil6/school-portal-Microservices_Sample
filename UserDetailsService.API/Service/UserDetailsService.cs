using AutoMapper;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.CustomModels;
using SchoolPortal.Common.Models.dboSchema;
using UserDetailsService.API.Repository;

namespace UserDetailsService.API.Service
{
	public class UserDetailsService : IUserDetailsService
	{
		private readonly IUserDetailsRepository _UserDetailRepository;
		private readonly IMapper _mapper;

		public UserDetailsService(IUserDetailsRepository UserDetailRepository, IMapper mapper)
		{
			_UserDetailRepository = UserDetailRepository;
			_mapper = mapper;
		}

		public async Task<UserDetail?> AddAsync(CreateUserDetailDto dto)
		{
			var UserDetail = _mapper.Map<UserDetail>(dto);

			await _UserDetailRepository.CreateAsync(UserDetail);

			return _mapper.Map<UserDetail?>(UserDetail);  // 🔥 Return the newly created UserDetail DTO
		}

		public async Task<bool> DeleteAsync(Guid id)
		{
			var success = await _UserDetailRepository.DeleteAsync(id); // Delete the company by ID
			if (!success)
			{
				throw new InvalidOperationException("Failed to delete UserDetail"); // Handle failure
			}
			return true;  // Return true if deletion was successful
		}

		public async Task<IEnumerable<UserDetail?>> GetAllAsync()
		{
			return await _UserDetailRepository.GetAllAsync();
		}

		public async Task<UserDetail?> GetByIdAsync(Guid id)
		{
			var UserDetail = await _UserDetailRepository.GetByIdAsync(id);
			return UserDetail == null ? null : _mapper.Map<UserDetail?>(UserDetail);
		}

		public async Task<bool> UpdateAsync(Guid id, UpdateUserDetailDto dto)
		{
			var UserDetail = await _UserDetailRepository.GetByIdAsync(id);

			if (UserDetail == null) return false;

			_mapper.Map(dto, UserDetail);

			return await _UserDetailRepository.UpdateAsync(id, UserDetail);
		}

		public async Task<SessionModel> GetUserSession(string userName, string password)
		{
			return await _UserDetailRepository.GetUserSession(userName, password);
		}

		public async Task<bool> AuthenticateUser(string userName, string password)
		{
			return await _UserDetailRepository.AuthenticateUser(userName, password);
		}
	}
}
