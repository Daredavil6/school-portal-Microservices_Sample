using SchoolPortal.Common.Models.dboSchema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPortal.Common.Models.CustomModels
{
    public class SessionModel
    {
        public UserDetail? userDetail { get; set; }
        public string? userRole { get; set; }
        public string? userDesignation { get; set; }
        public List<string>? userPrivileges { get; set; }
    }
}
