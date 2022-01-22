using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class NhanvienAccount
    {
        public int IdNhanvienAccount { get; set; }
        public string UidNhanvienAccount { get; set; } = null!;
        public string PwdNhanvienAccount { get; set; } = null!;
        public int IdNhanvien { get; set; }

        public virtual Nhanvien IdNhanvienNavigation { get; set; } = null!;
    }
}
