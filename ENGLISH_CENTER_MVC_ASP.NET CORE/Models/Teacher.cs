using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            Classes = new HashSet<Class>();
            TeacherAccounts = new HashSet<TeacherAccount>();
        }

        public int IdTeacher { get; set; }
        public byte[]? HinhanhTeacher { get; set; }
        public string HotenTeacher { get; set; } = null!;
        public string MailTeacher { get; set; } = null!;
        public string SdtTeacher { get; set; } = null!;
        public string? MotaTeacher { get; set; }

        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<TeacherAccount> TeacherAccounts { get; set; }
    }
}
