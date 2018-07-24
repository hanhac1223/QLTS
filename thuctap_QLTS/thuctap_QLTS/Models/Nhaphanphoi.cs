using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Nhaphanphoi
    {
        public Nhaphanphoi()
        {
            Taisan = new HashSet<Taisan>();
        }

        public int MaNpp { get; set; }
        public string TenNpp { get; set; }
        public string ViTri { get; set; }
        public int? Sdt { get; set; }
        public int? Xoa { get; set; }
        public int? MaNsx { get; set; }

        public Nhasanxuat MaNsxNavigation { get; set; }
        public ICollection<Taisan> Taisan { get; set; }
    }
}
