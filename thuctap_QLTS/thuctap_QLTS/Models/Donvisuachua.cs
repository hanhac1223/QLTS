using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Donvisuachua
    {
        public Donvisuachua()
        {
            Phieusua = new HashSet<Phieusua>();
        }

        public int MaDv { get; set; }
        public string TenDv { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public int? Sdt { get; set; }

        public ICollection<Phieusua> Phieusua { get; set; }
    }
}
