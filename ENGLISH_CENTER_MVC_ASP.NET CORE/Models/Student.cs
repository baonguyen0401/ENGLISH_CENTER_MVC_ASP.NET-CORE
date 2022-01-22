using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class Student
    {
        public Student()
        {
            ClassStudents = new HashSet<ClassStudent>();
            Payments = new HashSet<Payment>();
            StudentAccounts = new HashSet<StudentAccount>();
        }

        public int IdStudent { get; set; }
        public string HotenStudent { get; set; } = null!;
        public DateTime BirthdayStudent { get; set; }
        public string MailStudent { get; set; } = null!;
        public string SdtStudent { get; set; } = null!;
        public string? AddressStudent { get; set; }

        public virtual ICollection<ClassStudent> ClassStudents { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<StudentAccount> StudentAccounts { get; set; }
    }
}
