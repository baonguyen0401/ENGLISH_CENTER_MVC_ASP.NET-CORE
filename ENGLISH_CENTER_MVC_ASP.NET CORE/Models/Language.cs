using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class Language
    {
        public Language()
        {
            Courses = new HashSet<Course>();
        }

        public int IdLanguage { get; set; }
        public string? NameLanguage { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
