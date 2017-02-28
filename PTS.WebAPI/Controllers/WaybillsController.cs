using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PTS.WebAPI.Controllers
{
    [RoutePrefix("pts/Waybills")]
    public class WaybillsController : ApiController
    {
        // GET: api/Waybills
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Waybills/5
        public string Get(int id)
        {
            return "value";
        }

        [Route("Item")]
        public string GetByItem(int id)
        {
            
        }
    }
}
