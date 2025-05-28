using SchoolPortal.Common.BaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPortal.Common.DTOs
{
    public class CreateCityDto : BaseEntity
    {
        public string CityName { get; set; } = string.Empty;

        // These can be set from context/session in your service layer
        public Guid? CreatedBy { get; set; }
    }

    public class UpdateCityDto
    {
        public Guid Id { get; set; }              // Required for identifying the city to update
        public string CityName { get; set; } = string.Empty;

        // These can be set from context/session in your service layer
        public Guid? ModifiedBy { get; set; }
    }

    public class ViewCityDto
    {
        public Guid Id { get; set; }
        public string? CityNameName { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public Guid? ModifiedBy { get; set; }
        public string Status { get; set; }
        public string? StatusMessage { get; set; }
    }
}
