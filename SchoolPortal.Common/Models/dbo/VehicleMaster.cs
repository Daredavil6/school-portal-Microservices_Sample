using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("VehicleMaster")]
public partial class VehicleMaster
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string VehicleNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Model { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Make { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string VehicleType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string VehicleRegistrationNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string InsuranceCompany { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? InsurancePremium { get; set; }

    public int? SeatingCapacity { get; set; }

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

