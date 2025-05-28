using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("BillMaster")]
public partial class BillMaster
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string Number { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Description { get; set; }

    public Guid VendorId { get; set; }

    public Guid? VehicleId { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TaxAmount { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TotalAmount { get; set; }

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

    [Required]
    [StringLength(10)]
    [Unicode(false)]
    public string Status { get; set; }

    [StringLength(255)]
    public string StatusMessage { get; set; }
}

