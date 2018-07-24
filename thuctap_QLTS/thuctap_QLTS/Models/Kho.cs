using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Kho
    {
        public int MaKho { get; set; }
        public string TenKho { get; set; }
        public string ViTri { get; set; }
        public int? Sdt { get; set; }
        public int? Xoa { get; set; }
    }
}
