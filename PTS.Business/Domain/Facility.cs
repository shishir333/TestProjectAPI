using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Business.Domain
{
    public class Facility : IDomainBase
    {
        public int Id { get; set; }

        public string FacilityId { get; set; }

        public Address Address { get; set; }

        public bool IsActive { get; set; }
    }
}
