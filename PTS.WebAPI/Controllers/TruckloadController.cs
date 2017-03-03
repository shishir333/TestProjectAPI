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
    [RoutePrefix("pts/Truckload")]
    public class TruckloadController : ApiController
    {
        #region Get Truckload

        // GET: pts/Truckload/{id} - Get truckload info by ID
        /// <summary>
        /// Get truckload by ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Truckload</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(TruckloadResponseModel))]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new TruckloadResponseModel());
        }

        // GET: pts/Truckload/item/{id} - Get truckload info by Item ID
        /// <summary>
        /// Get truckload info by Item
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Truckload</returns>
        [HttpGet]
        [Route("Item/{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(TruckloadResponseModel))]
        public HttpResponseMessage GetByItem(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new TruckloadResponseModel());
        }

        #endregion

        #region Update Truckload

        // POST/pts/truckload/{id} – update truckload/batch status
        /// <summary>
        /// update truckload/batch status
        /// </summary>
        /// <param name="id"></param>
        /// <param name="batchStatus">Status = OPEN/CLOSED</param>
        /// <returns>Truckload Status</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(UpdateTruckloadResponseModel))]
        [HttpPost]
        public HttpResponseMessage UpdateTruckload(int id, string batchStatus)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new UpdateTruckloadResponseModel());
        }

        #endregion
    }
}
