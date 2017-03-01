using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using PTS.WebAPI.Models;
using PTS.WebAPI.Models.Account;
using PTS.WebAPI.Filters;
using Swashbuckle.Swagger.Annotations;

namespace PTS.WebAPI.Controllers
{
    /// <summary>
    /// Facilities
    /// </summary>
    [RoutePrefix("pts/Facilities")]
    public class FacilitiesController : ApiController
    {
        // GET /pts/facilities - Get a list of all operating facilities
        /// <summary>
        /// Get a list of all operating facilities
        /// </summary>
        /// <returns>Facilities</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(FacilityResponseModel))]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new FacilityResponseModel());
        }
    }
}
