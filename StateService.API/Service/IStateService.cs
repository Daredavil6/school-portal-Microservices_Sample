using SchoolPortal.Common.DTOs;
using SchoolPortal.Common.Models.dboSchema;
using SchoolPortal.Common.Service;

namespace StateService.API.Service
{
    public interface IStateService : IGenericService<StateMaster, CreateStateDto, UpdateStateDto>
    {
        // Add any country-specific service methods here
    }
}
