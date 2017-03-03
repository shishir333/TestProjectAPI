using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Business.Domain
{
    public class Network : IDomainBase
    {
        public int Id { get; set; }

        public string Mode { get; set; }

        public string IP { get; set; }

        public string Mask { get; set; }

        public string Gateway { get; set; }

        public bool IsActive { get; set; }
    }
}
