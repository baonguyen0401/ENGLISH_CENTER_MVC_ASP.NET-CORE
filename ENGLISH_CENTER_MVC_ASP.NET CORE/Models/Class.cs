using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class Class
    {
        public Class()
        {
            ClassStudents = new HashSet<ClassStudent>();
            ClassWeekdays = new HashSet<ClassWeekday>();
            Payments = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Ngaybatdau { get; set; }
        public DateTime Ngayketthuc { get; set; }
        public decimal HocPhi { get; set; }
        public int IdTeacher { get; set; }
        public int IdCourse { get; set; }

        public virtual Course IdCourseNavigation { get; set; } = null!;
        public virtual Teacher IdTeacherNavigation { get; set; } = null!;
        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
        public virtual ICollection<ClassWeekday> ClassWeekdays { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
