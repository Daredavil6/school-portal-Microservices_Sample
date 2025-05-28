using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("VisitorMaster")]
public partial class VisitorMaster
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string VisitorMasterName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime VisitorMasterDate { get; set; }

    [Column(TypeName = "time(0)")]
    public TimeSpan TimeOfArrival { get; set; }

    [Column(TypeName = "time(0)")]
    public TimeSpan TimeOfExit { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Purpose { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ContactPerson { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string VisitorMasterAddress { get; set; }

    public Guid VisitorMasterCityId { get; set; }

    public Guid VisitorMasterStateId { get; set; }

    public Guid VisitorMasterCountryId { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string VisitorMasterZipCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string VisitorMasterContactNumber { get; set; }

    public bool? VisitorMasterIsActive { get; set; }

    public Guid VisitorMasterCompanyId { get; set; }

    public Guid VisitorMasterSchoolId { get; set; }

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

