using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("SchoolMaster")]
public partial class SchoolMaster
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Description { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Address2 { get; set; }

    public Guid? CityId { get; set; }

    public Guid? StateId { get; set; }

    public Guid? CountryId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ZipCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Phone { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string EstablishmentYear { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Mobile { get; set; }

    public Guid? JudistrictionCityId { get; set; }

    public Guid? JudistrictionStateId { get; set; }

    public Guid? JudistrictionCountryId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string BankName { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string BankAddress1 { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string BankAddress2 { get; set; }

    public Guid? BankCityId { get; set; }

    public Guid? BankStateId { get; set; }

    public Guid? BankCountryId { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BankZipCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string AccountNumber { get; set; }

    public bool IsActive { get; set; }

    public bool IsDeleted { get; set; }

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

    [StringLength(250)]
    [Unicode(false)]
    public string StatusMessage { get; set; }
}

