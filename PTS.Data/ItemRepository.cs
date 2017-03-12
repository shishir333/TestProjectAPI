using PTS.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTS.Data.DB;

namespace PTS.Data
{
    public class ItemRepository : GenericRepository<Item>, IItemRepository<Item>
    {
        public ItemRepository(ProgisticsEntities entities) : base(entities)
        {
            //Adding injection
        }

        public string TestMethod()
        {
            return "test..";
        }
    }
}
