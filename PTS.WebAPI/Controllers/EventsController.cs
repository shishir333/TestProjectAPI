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
    [RoutePrefix("api")]
    public class EventsController : ApiController
    {
        // GET: pts/events/item/{id} - Get a specific event by item ID
        /// <summary>
        /// Get a specific event by item ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Item</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(EventResponse))]
        [HttpGet]
        [Route("events/item/{id}")]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new EventResponse(true, false,false,false).Items);
        }

        // GET: pts/events/waybill/{id} - Get events given the waybill ID
        [HttpGet]
        [Route("events/waybill/{id}")]
        [Route("events/shipment/{id}")]
        [Route("events/ref/{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ItemResponse))]
        public HttpResponseMessage GetByItem(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new EventResponse(true, true, true, true).Items);
        }
    }
}
