using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Nhasanxuat
    {
        public Nhasanxuat()
        {
            Nhaphanphoi = new HashSet<Nhaphanphoi>();
        }

        public int MaNsx { get; set; }
        public string TeNsx { get; set; }
        public string DiaChi { get; set; }
        public int? Sdt { get; set; }

        public ICollection<Nhaphanphoi> Nhaphanphoi { get; set; }
    }
}
