using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Chucvu
    {
        public Chucvu()
        {
            Nhanvien = new HashSet<Nhanvien>();
        }

        public int MaCv { get; set; }
        public string TenCv { get; set; }
        public string MoTa { get; set; }
        public int? Xoa { get; set; }

        public ICollection<Nhanvien> Nhanvien { get; set; }
    }
}
