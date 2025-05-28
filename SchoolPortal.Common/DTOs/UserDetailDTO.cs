using SchoolPortal.Common.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPortal.Common.DTOs
{
	public class CreateUserDetailDto : BaseEntity
	{
		public string UserName { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public Guid DesignationId { get; set; }
		public Guid? UserRoleId { get; set; }
		public bool? IsSuperUser { get; set; }
		public Guid? CompanyId { get; set; }
		public Guid? SchoolId { get; set; }
		public Guid? CreatedBy { get; set; }
	}

	public class UpdateUserDetailDto
	{
		public Guid Id { get; set; }
		public string UserName { get; set; }
		public string UserPassword { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public Guid DesignationId { get; set; }
		public Guid? UserRoleId { get; set; }
		public bool? IsSuperUser { get; set; }
		public Guid? CompanyId { get; set; }
		public Guid? SchoolId { get; set; }
		public Guid? ModifiedBy { get; set; }
	}

	public class ViewUserDetailDto
	{
		public Guid Id { get; set; }
		public string? UserName { get; set; }
		public string? UserPassword { get; set; }
		public string? FirstName { get; set; }
		public string? LastName { get; set; }
		public string? EmailAddress { get; set; }
		public string? Designation { get; set; }
		public string? UserRoleId { get; set; }
		public List<string> UserPriviledges { get; set; } = new List<string>();
		public bool? IsSuperUser { get; set; }
		public string? CompanyName { get; set; }
		public string? SchoolName { get; set; }
		public Guid? ModifiedBy { get; set; }
		public string? Status { get; set; }
		public string? StatusMessage { get; set; }
	}

	public class LoginDto
	{
		public string UserName { get; set; }
		public string UserPassword { get; set; }
	}
}
