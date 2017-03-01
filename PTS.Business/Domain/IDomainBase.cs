using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Business.Domain
{
    public interface IDomainBase
    {
        int Id { get; set; }
        
        bool IsActive { get; set; }
    }
}
