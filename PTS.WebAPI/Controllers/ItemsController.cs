using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PTS.WebAPI.Models;
using Swashbuckle.Swagger.Annotations;

namespace PTS.WebAPI.Controllers
{
    [RoutePrefix("pts/Items")]
    public class ItemsController : ApiController
    {
        // GET: pts/Items/{id} - Get a specific item by ID
        /// <summary>
        /// Get a specific item by ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Item</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ItemResponse))]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new ItemResponse(true, false).Items);
        }

        // GET: pts/items/waybill/{id} - Get waybill given the Item ID
        [HttpGet]
        [Route("waybill/{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ItemResponse))]
        public HttpResponseMessage GetByItem(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new ItemResponse(true, true).Items);
        }
    }
}
