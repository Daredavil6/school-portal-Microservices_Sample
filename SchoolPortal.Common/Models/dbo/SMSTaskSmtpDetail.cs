using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SchoolPortal.Common.Models.dboSchema;


namespace SchoolPortal.Common.Models.dboSchema;

public partial class SMSTaskSmtpDetail
{
    [Key]
    public Guid Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string FromAddress { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Gateway { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string UserName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Password { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string Subject { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string BodyText { get; set; }

    public Guid? TaskId { get; set; }

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

