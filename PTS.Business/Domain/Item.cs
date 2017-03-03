using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Business.Domain
{
    public class Item : IDomainBase
    {
        public int Id { get; set; }

        public int Waybill { get; set; }

        public int Truck { get; set; }

        public Facility Facility { get; set; }

        public string Location { get; set; }

        public bool IsDamaged { get; set; }

        public bool IsOSD { get; set; }

        public string Notes { get; set; }

        public string Desc { get; set; }

        public Damage Damage { get; set; }

        public string Who { get; set; }

        public bool IsActive { get; set; }
    }
}
