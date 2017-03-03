using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PTS.WebAPI.Models.Action;
using Swashbuckle.Swagger.Annotations;

namespace PTS.WebAPI.Controllers
{
    [RoutePrefix("pts")]
    public class ActionsController : ApiController
    {
        #region Preload
        // POST /pts/preload – prints labels in preparation for onboarding
        /// <summary>
        /// Prints labels in preparation for onboarding
        /// </summary>
        /// <param name="request">Preload Request with waybills</param>
        /// <returns>Preload Response</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(PreloadResponseModel))]
        [HttpPost]
        [Route("Preload")]
        public HttpResponseMessage Preload(PreloadRequestModel request)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new PreloadResponseModel());
        }

        #endregion

        #region Onboard

        // POST /pts/onboard – starts an item on its journey
        /// <summary>
        /// Starts an item on its journey
        /// </summary>
        /// <param name="request">Onboard Request with item/waybills ID pairs</param>
        /// <returns>Onboard Response</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(OnboardResponseModel))]
        [HttpPost]
        [Route("Onboard")]
        public HttpResponseMessage Onboard(OnboardRequestModel request)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new OnboardResponseModel());
        }

        #endregion

        #region Load

        // POST /pts/load – starts an item on its journey
        /// <summary>
        /// Starts an item on its journey
        /// </summary>
        /// <param name="request">Load Request with item IDs</param>
        /// <returns>Load Response</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(LoadResponseModel))]
        [HttpPost]
        [Route("Load")]
        public HttpResponseMessage Load(LoadRequestModel request)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new LoadResponseModel());
        }

        #endregion

        #region Unload

        // POST /pts/unload – mark an item unloaded from a truck at a warehouse
        /// <summary>
        /// Mark an item unloaded from a truck at a warehouse
        /// </summary>
        /// <param name="request">Unload Request with item IDs</param>
        /// <returns>Unload Response</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(UnloadResponseModel))]
        [HttpPost]
        [Route("Unload")]
        public HttpResponseMessage Unload(UnloadRequestModel request)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new UnloadResponseModel());
        }

        #endregion

        #region Transfer

        // POST /pts/transfer – starts an item on its journey
        /// <summary>
        /// Starts an item on its journey
        /// </summary>
        /// <param name="request">Transfer Request with item IDs</param>
        /// <returns>Response</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(TransferResponseModel))]
        [HttpPost]
        [Route("Transfer")]
        public HttpResponseMessage Transfer(TransferRequestModel request)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new TransferResponseModel());
        }

        #endregion


        #region Damage

        // POST /pts/damage – Mark on or more items as damaged
        /// <summary>
        /// Mark on or more items as damaged
        /// </summary>
        /// <param name="request">Damage Request with item IDs</param>
        /// <returns>Response</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(DamageResponseModel))]
        [HttpPost]
        [Route("Damage")]
        public HttpResponseMessage Damage(DamageRequestModel request)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new DamageResponseModel());
        }

        #endregion

        #region Delivered

        // POST /pts/delivered – marks items as delivered
        /// <summary>
        /// Marks items as delivered
        /// </summary>
        /// <param name="request">Delivered Request with item IDs</param>
        /// <returns>Response</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(DeliveredResponseModel))]
        [HttpPost]
        [Route("Delivered")]
        public HttpResponseMessage Delivered(DeliveredRequestModel request)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new DeliveredResponseModel());
        }

        #endregion
    }
}
