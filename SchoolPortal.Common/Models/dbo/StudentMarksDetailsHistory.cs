using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("StudentMarksDetailsHistory")]
public partial class StudentMarksDetailsHistory
{
    [Key]
    public Guid Id { get; set; }

    public Guid StudentMatksId { get; set; }

    public Guid StudentGUID { get; set; }

    public Guid SujectCategoryId { get; set; }

    public Guid SessionId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Marks1Q1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Marks2Q1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Marks1Q2 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Marks2Q2 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Marks1Q3 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Marks2Q3 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MarksFA1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MarksFA2 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MarksFA3 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MarksFA4 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MarksSA1 { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? MarksSA2 { get; set; }

    public Guid ClassMasterId { get; set; }

    public Guid SectionId { get; set; }

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

