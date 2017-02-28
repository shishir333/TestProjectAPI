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
    /// Account related Operations
    /// </summary>
    [RoutePrefix("pts/Account")]
    public class AccountController : ApiController
    {
        /// <summary>
        /// Login to generate API Key for subsequent requests
        /// </summary>
        /// <param name="request">Login Request</param>
        /// <returns>Login Response</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(LoginResponseModel))]
        [HttpPost]
        [Route("Login")]
        [ValidateModel]
        public HttpResponseMessage Login(LoginRequestModel request)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new LoginResponseModel());
        }
    }
}
