using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Business.Domain
{
    public class Waybill : IDomainBase
    {
        public int Id { get; set; }

        public int ItemId { get; set; }

        public string Desc { get; set; }

        public bool IsActive { get; set; }
    }
}
