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
    [RoutePrefix("pts/Waybills")]
    public class WaybillsController : ApiController
    {
        // GET: pts/Waybills - Get all waybills
        //public HttpResponseMessage Get()
        //{
        //    return Request.CreateResponse(HttpStatusCode.OK, new WaybillResponse(true, true));
        //}

        // GET: pts/Waybills/{id} - Get a specific waybill by ID
        /// <summary>
        /// Get a specific waybill by ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Waybill</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(WaybillResponse))]
        [HttpGet]
        public HttpResponseMessage Get(int id, string expand = null)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new WaybillResponse(true, true));
        }

        // GET: pts/Waybills/item/{id} - Get waybill given the Item ID
        [HttpGet]
        [Route("Item/{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(WaybillResponse))]
        public HttpResponseMessage GetByItem(int id, string expand = null)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new WaybillResponse(true, true));
        }

        // GET /pts/waybills/customer/{name} – Get waybills that match the customer name
        [HttpGet]
        [Route("Customer/{name}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(WaybillResponse))]
        public HttpResponseMessage GetByCustomer(string name, string expand = null)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new WaybillResponse(true, true));
        }

        // GET /pts/waybills/dest/{address} – Get waybills that match by address, using “address1”
        [HttpGet]
        [Route("Dest/{address}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(WaybillResponse))]
        public HttpResponseMessage GetByAddress(string address, string expand = null)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new WaybillResponse(true, true));
        }

        // GET /pts/waybills/shipment/{id} – Get waybill(s) that match by shipment ID
        [HttpGet]
        [Route("Shipment/{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(WaybillResponse))]
        public HttpResponseMessage GetByShipmentId(int id, string expand = null)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new WaybillResponse(true, true));
        }

        // GET /pts/waybills/shipment_ref/{id} – Get waybills that match by shipment Reference
        [HttpGet]
        [Route("Shipment_ref/{reference}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(WaybillResponse))]
        public HttpResponseMessage GetByShipmentRef(int reference, string expand = null)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new WaybillResponse(true, true));
        }
    }
}
