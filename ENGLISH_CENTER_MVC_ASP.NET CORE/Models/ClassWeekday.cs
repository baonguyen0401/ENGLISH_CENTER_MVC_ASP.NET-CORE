using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class ClassWeekday
    {
        public int IdClass { get; set; }
        public int IdWeekday { get; set; }
        public string? Hours { get; set; }

        public virtual Class IdClassNavigation { get; set; } = null!;
        public virtual WeekDay IdWeekdayNavigation { get; set; } = null!;
    }
}
