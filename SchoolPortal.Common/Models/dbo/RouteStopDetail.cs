using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

public partial class RouteStopDetail
{
    [Key]
    public Guid Id { get; set; }

    public Guid RouteMasterId { get; set; }

    public Guid RouteDetailId { get; set; }

    public Guid LocationId { get; set; }

    public Guid StopNumber { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string PickUpTime { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string DropTime { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? OneWayMonthlyFee { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TwoWayMonthlyFee { get; set; }

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

