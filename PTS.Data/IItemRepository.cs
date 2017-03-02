using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTS.Data
{
    public interface IItemRepository<T> : IRepository<T> where T : class
    {
        string TestMethod();
    }
}
