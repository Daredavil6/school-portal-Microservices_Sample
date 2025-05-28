using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("DriverMaster")]
public partial class DriverMaster
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string FirstName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LastName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string FathersName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DOB { get; set; }

    public Guid QualifcationId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Mobile_Phone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Phone { get; set; }

    public Guid CityId { get; set; }

    public Guid StateId { get; set; }

    public Guid CountryId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ZipCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Image { get; set; }

    public Guid CompanyId { get; set; }

    public Guid SchoolId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LicenceNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LicenceIssueDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LicenceValidUptoDate { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string LicenceDescription { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string LicenceImage { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LicenceType { get; set; }

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

