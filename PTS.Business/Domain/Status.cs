using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Business.Domain
{
    public class PrinterStatus : IDomainBase
    {
        public int Id { get; set; }

        public string PrinterId { get; set; }

        public string Status { get; set; }

        public int ErrorCount { get; set; }
        
        public int JobCount { get; set; }
        
        public int JobCompletedCount { get; set; }

        public string Facility { get; set; }

        public Network Network { get; set; }

        public int Interval { get; set; }

        public string Printer { get; set; }

        public DateTime LastSeen { get; set; }
        
        public bool IsActive { get; set; }
    }
}
