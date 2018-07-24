using System;
using System.Collections.Generic;

namespace thuctap_QLTS.Models
{
    public partial class Mucdichsudung
    {
        public Mucdichsudung()
        {
            Taisan = new HashSet<Taisan>();
        }

        public int MaMucDich { get; set; }
        public string TenMucDich { get; set; }
        public string MoTa { get; set; }
        public int? Xoa { get; set; }

        public ICollection<Taisan> Taisan { get; set; }
    }
}
