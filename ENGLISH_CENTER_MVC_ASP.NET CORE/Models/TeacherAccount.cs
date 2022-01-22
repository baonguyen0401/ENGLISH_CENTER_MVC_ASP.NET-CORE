using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class TeacherAccount
    {
        public int IdTeacherAccount { get; set; }
        public string UidTeacherAccount { get; set; } = null!;
        public string PwdTeacherAccount { get; set; } = null!;
        public int IdTeacher { get; set; }

        public virtual Teacher IdTeacherNavigation { get; set; } = null!;
    }
}
