using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

[Table("SMSTask")]
public partial class SMSTask
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Name { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Description { get; set; }

    [Required]
    [StringLength(1)]
    [Unicode(false)]
    public string NotificationSendEmail { get; set; }

    [Required]
    [StringLength(1)]
    [Unicode(false)]
    public string NotificationSendSMS { get; set; }

    public Guid NotificationReceiverId { get; set; }

    [Required]
    [StringLength(50)]
    [Unicode(false)]
    public string RepeatSchedule { get; set; }

    public Guid Status_Id { get; set; }

    public int? LastRunStatusId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? LastRunDate { get; set; }

    public bool? IsReadOnly { get; set; }

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

