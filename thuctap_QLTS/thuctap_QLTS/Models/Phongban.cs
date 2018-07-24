using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Phongban
    {
        public Phongban()
        {
            Nhanvien = new HashSet<Nhanvien>();
        }

        public int MaPb { get; set; }
        public string TenPb { get; set; }
        public string ViTri { get; set; }
        public int? Sdt { get; set; }
        public int? Xoa { get; set; }

        public ICollection<Nhanvien> Nhanvien { get; set; }
    }
}
