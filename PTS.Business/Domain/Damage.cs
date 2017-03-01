using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Business.Domain
{
    public class Damage: IDomainBase
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Image { get; set; }

        public string Notes { get; set; }

        public bool IsActive { get; set; }
    }
}
