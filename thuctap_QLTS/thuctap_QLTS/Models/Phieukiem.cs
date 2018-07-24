using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Phieukiem
    {
        public Phieukiem()
        {
            Taisan = new HashSet<Taisan>();
        }

        public int MaPk { get; set; }
        public string TenPk { get; set; }
        public int? NamKiem { get; set; }
        public int? Xoa { get; set; }
        public int? MaTtkiem { get; set; }

        public ICollection<Taisan> Taisan { get; set; }
    }
}
