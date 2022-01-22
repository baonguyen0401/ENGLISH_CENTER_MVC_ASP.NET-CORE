using System;
using System.Collections.Generic;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class Nhanvien
    {
        public Nhanvien()
        {
            NhanvienAccounts = new HashSet<NhanvienAccount>();
        }

        public int IdNhanvien { get; set; }
        public string NameNhanvien { get; set; } = null!;
        public string ChucDanhNhanvien { get; set; } = null!;
        public DateTime BirthdayNhanvien { get; set; }
        public string MailNhanvien { get; set; } = null!;
        public string SdtNhanvien { get; set; } = null!;

        public virtual ICollection<NhanvienAccount> NhanvienAccounts { get; set; }
    }
}
