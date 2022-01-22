using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class Course
    {
        public Course()
        {
            Classes = new HashSet<Class>();
        }

        public int IdCourse { get; set; }
        public int SoBuoiHoc { get; set; }
        public string? MoTaKhoaHoc { get; set; }
        public int IdLevel { get; set; }
        public int IdLanguage { get; set; }

        public virtual Language IdLanguageNavigation { get; set; } = null!;
        public virtual Level IdLevelNavigation { get; set; } = null!;
        public virtual ICollection<Class> Classes { get; set; }
    }
}
