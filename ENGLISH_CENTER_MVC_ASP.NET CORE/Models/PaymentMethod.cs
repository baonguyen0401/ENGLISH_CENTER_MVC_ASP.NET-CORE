using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class PaymentMethod
    {
        public int IdPaymentMethod { get; set; }
        public string NamePaymentMethod { get; set; } = null!;
        public int IdPayment { get; set; }

        public virtual Payment IdPaymentNavigation { get; set; } = null!;
    }
}
