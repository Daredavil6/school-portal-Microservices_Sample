using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("TimeTableSubstitutionDetailsHistory")]
public partial class TimeTableSubstitutionDetailsHistory
{
    [Key]
    public Guid Id { get; set; }

    public Guid SessionId { get; set; }

    public Guid PeriodId { get; set; }

    public Guid TeacherId { get; set; }

    public Guid TeacherNewId { get; set; }

    public Guid SubjectId { get; set; }

    public Guid ClassMasterId { get; set; }

    public Guid SectionId { get; set; }

    public Guid DayOfWeek { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SubstitutionDate { get; set; }

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

