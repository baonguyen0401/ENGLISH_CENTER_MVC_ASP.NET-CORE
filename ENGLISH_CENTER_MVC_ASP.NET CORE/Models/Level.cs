using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class Level
    {
        public Level()
        {
            Courses = new HashSet<Course>();
        }

        public int IdLevel { get; set; }
        public string KiHieu { get; set; } = null!;
        public string NameLevel { get; set; } = null!;

        public virtual ICollection<Course> Courses { get; set; }
    }
}
