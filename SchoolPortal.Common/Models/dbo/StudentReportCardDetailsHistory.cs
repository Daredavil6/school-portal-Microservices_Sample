using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("StudentReportCardDetailsHistory")]
public partial class StudentReportCardDetailsHistory
{
    [Key]
    public Guid Id { get; set; }

    public Guid ReportCardId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SubjectType { get; set; }

    public int? SubjectId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? QuarterMarks { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MarksFA1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MarksFA2 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MarksSA { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Grade { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string GradeFA1 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string GradeFA2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string GradeSA { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalMarks { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TotalGrade { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalMarksQuarter { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalMMarksFA1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalMMarksFA2 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalMMarksSA { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalMMarksFinal { get; set; }

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

