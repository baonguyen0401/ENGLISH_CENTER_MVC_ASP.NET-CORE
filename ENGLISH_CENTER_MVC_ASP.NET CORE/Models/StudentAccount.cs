using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class StudentAccount
    {
        public int IdStudentAccount { get; set; }
        public int IdStudent { get; set; }
        public string UidStudentAccount { get; set; } = null!;
        public string PwdStudentAccount { get; set; } = null!;
        public bool KichHoat { get; set; }

        public virtual Student IdStudentNavigation { get; set; } = null!;
    }
}
