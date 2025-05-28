using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("EmpCatLeaveDetailsHistory")]
public partial class EmpCatLeaveDetailsHistory
{
    [Key]
    public Guid Id { get; set; }

    public Guid CategoryId { get; set; }

    public Guid LeaveTypeId { get; set; }

    [Column(TypeName = "decimal(18, 1)")]
    public decimal? TotalLeaves { get; set; }

    public Guid SessionId { get; set; }

    public Guid SchoolId { get; set; }

    public Guid CompanyId { get; set; }

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

