using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("EmpSalaryMaster")]
public partial class EmpSalaryMaster
{
    [Key]
    public Guid Id { get; set; }

    public Guid EmployeeId { get; set; }

    [Required]
    [StringLength(4)]
    [Unicode(false)]
    public string Month { get; set; }

    [Required]
    [StringLength(4)]
    [Unicode(false)]
    public string Year { get; set; }

    public Guid Session { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime BatchPrintDate { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? BasicSalary { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Allowances { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Deductions { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? NetSalary { get; set; }

    public Guid TotalDays { get; set; }

    [Column(TypeName = "decimal(18, 1)")]
    public decimal? PresentDays { get; set; }

    [Column(TypeName = "decimal(18, 1)")]
    public decimal? AbsentDays { get; set; }

    [Column(TypeName = "decimal(18, 1)")]
    public decimal? LeaveDays { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string LeaveDescription { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string LeaveBalanceDescription { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? PerDaySalary { get; set; }

    public Guid DepartmentId { get; set; }

    public Guid DesignationId { get; set; }

    public Guid GradeId { get; set; }

    public Guid CompanyId { get; set; }

    public Guid SchoolId { get; set; }

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

