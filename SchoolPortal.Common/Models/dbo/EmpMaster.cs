using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("EmpMaster")]
public partial class EmpMaster
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Salutation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DOB { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string FathersName { get; set; }

    public Guid Gender { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Description { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DOJ { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string MaritalStatus { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AadharNumber { get; set; }

    public Guid BloodGroupId { get; set; }

    public Guid GradeId { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Image { get; set; }

    public Guid OldEmployeeId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string YearsOfExperience { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ProbationPeriod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ProbationStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ProbationEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ConfirmationDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PANNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ESICNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PFNumber { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string CurrentAddress { get; set; }

    public Guid CurrentAddressCityId { get; set; }

    public Guid CurrentAddressStateId { get; set; }

    public Guid CurrentAddressCountryId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CurrentAddressZipCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PermanentAddress { get; set; }

    public Guid PermanentAddressCityId { get; set; }

    public Guid PermanentAddressStateId { get; set; }

    public Guid PermanentAddressCountryId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PermanentAddressZipCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Phone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Mobile { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Email { get; set; }

    public Guid DepartmentId { get; set; }

    public Guid DesignationId { get; set; }

    public Guid PaymentModeId { get; set; }

    public Guid TypeId { get; set; }

    public Guid CategoryId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BankAccountNumber { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BankName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string BankAddress { get; set; }

    public Guid BankAddressCityId { get; set; }

    public Guid BankAddressStateId { get; set; }

    public Guid BankAddressCountryId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BankAddressZipCode { get; set; }

    public Guid SchoolId { get; set; }

    public Guid CompanyId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LicenceNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LicenceIssueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LicenceValidUptoDate { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string LicenceDescription { get; set; }

    public Guid LicenceIssueState { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string LicenceImage { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LicenceType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateOfLeaving { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PreveiousSchoolCompany { get; set; }

    public bool? MathsUpToClass { get; set; }

    public bool? EnglishUpToClass { get; set; }

    public bool? SSTUptoClass { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

    public Guid? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    public Guid? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Status { get; set; }

    [StringLength(255)]
    public string StatusMessage { get; set; }
}

