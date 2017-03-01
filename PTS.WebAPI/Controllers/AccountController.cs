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
    [RoutePrefix("pts")]
    public class AccountController : ApiController
    {
        /// <summary>
        /// Authenticate to generate API Key for subsequent requests to API
        /// </summary>
        /// <param name="request">Authenticate Request</param>
        /// <returns>Authenticate Response</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(AuthenticateResponseModel))]
        [HttpPost]
        [Route("Authenticate")]
        [ValidateModel]
        public HttpResponseMessage Authenticate(AuthenticateRequestModel request)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new AuthenticateResponseModel());
        }

        /// <summary>
        /// Login user
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
