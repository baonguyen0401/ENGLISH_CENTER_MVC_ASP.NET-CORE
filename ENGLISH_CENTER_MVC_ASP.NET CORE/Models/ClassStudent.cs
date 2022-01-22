using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class ClassStudent
    {
        public int IdStudent { get; set; }
        public int IdClass { get; set; }
        public int IdClassStudent { get; set; }

        public virtual Class IdClassNavigation { get; set; } = null!;
        public virtual Student IdStudentNavigation { get; set; } = null!;
    }
}
