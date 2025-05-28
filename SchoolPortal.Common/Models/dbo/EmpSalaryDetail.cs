using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

public partial class EmpSalaryDetail
{
    [Key]
    public Guid Id { get; set; }

    public Guid SalaryMasterId { get; set; }

    public Guid SalaryHistoryMasterId { get; set; }

    public Guid DesigGradeDetailsId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Value { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SalaryType { get; set; }

    public bool IsDeduction { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SalaryCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string SalaryDescription { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SalaryHead { get; set; }

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

