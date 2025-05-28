using AutoMapper;
using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.dboSchema;
using StateService.API.Repository;

namespace StateService.API.Service
{
    public class StateService : IStateService
    {
        private readonly IStateRepository _stateRepository;
        private readonly IMapper _mapper;

        public StateService(IStateRepository StateRepository, IMapper mapper)
        {
            _stateRepository = StateRepository;
            _mapper = mapper;
        }

        public async Task<StateMaster?> AddAsync(CreateStateDto dto)
        {
            var State = _mapper.Map<StateMaster>(dto);

            await _stateRepository.CreateAsync(State);

            return _mapper.Map<StateMaster?>(State);  // 🔥 Return the newly created State DTO
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var success = await _stateRepository.DeleteAsync(id); // Delete the company by ID
            if (!success)
            {
                throw new InvalidOperationException("Failed to delete State"); // Handle failure
            }
            return true;  // Return true if deletion was successful
        }

        public async Task<IEnumerable<StateMaster?>> GetAllAsync()
        {
            return await _stateRepository.GetAllAsync();
        }

        public async Task<StateMaster?> GetByIdAsync(Guid id)
        {
            var State = await _stateRepository.GetByIdAsync(id);
            return State == null ? null : _mapper.Map<StateMaster?>(State);
        }

        public async Task<bool> UpdateAsync(Guid id, UpdateStateDto dto)
        {
            var State = await _stateRepository.GetByIdAsync(id);

            if (State == null) return false;

            _mapper.Map(dto, State);

            return await _stateRepository.UpdateAsync(id, State);
        }


    }
}
