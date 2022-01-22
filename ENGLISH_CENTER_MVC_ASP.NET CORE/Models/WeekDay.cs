using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class WeekDay
    {
        public WeekDay()
        {
            ClassWeekdays = new HashSet<ClassWeekday>();
        }

        public int IdWd { get; set; }
        public string NameDay { get; set; } = null!;

        public virtual ICollection<ClassWeekday> ClassWeekdays { get; set; }
    }
}
