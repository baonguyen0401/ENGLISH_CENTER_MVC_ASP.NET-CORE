using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class Payment
    {
        public Payment()
        {
            PaymentMethods = new HashSet<PaymentMethod>();
        }

        public int IdPayment { get; set; }
        public DateTime PaymentDate { get; set; }
        public string Status { get; set; } = null!;
        public int IdStudent { get; set; }
        public int Id { get; set; }

        public virtual Class IdNavigation { get; set; } = null!;
        public virtual Student IdStudentNavigation { get; set; } = null!;
        public virtual ICollection<PaymentMethod> PaymentMethods { get; set; }
    }
}
