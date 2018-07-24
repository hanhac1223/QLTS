using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Trangthai
    {
        public Trangthai()
        {
            Taisan = new HashSet<Taisan>();
        }

        public int MaTt { get; set; }
        public string TenTt { get; set; }
        public string MoTa { get; set; }
        public int? Xoa { get; set; }

        public ICollection<Taisan> Taisan { get; set; }
    }
}
