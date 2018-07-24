using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Loaitaisan
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public int? Xoa { get; set; }

        public Taisan MaLoaiNavigation { get; set; }
    }
}
