using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Phieusua
    {
        public int MaPhieu { get; set; }
        public string TenPhieu { get; set; }
        public DateTime? NgayBdsua { get; set; }
        public DateTime? NgayKtsua { get; set; }
        public int? ChiPhi { get; set; }
        public string TrangThai { get; set; }
        public int? MaDv { get; set; }

        public Donvisuachua MaDvNavigation { get; set; }
    }
}
