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
    [RoutePrefix("pts/Printers")]
    public class PrintersController : ApiController
    {
        #region Printer Status
        /// <summary>
        /// Get status of all printers
        /// </summary>
        /// <returns>All Printer Status</returns>
        // GET: pts/Printers - Get status of all printers
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(PrinterStatusResponseModel))]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new PrinterStatusResponseModel());
        }

        // GET: pts/Printers/{id} - Get status of a printer by ID
        /// <summary>
        /// Get status of a printer by ID
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns>Printer Status</returns>
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(PrinterStatusResponseModel))]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new PrinterStatusResponseModel());
        }

        // GET: pts/Printers/Facility/{id} - Get the status of all printers assigned to a facility
        /// <summary>
        /// Get the status of all printers assigned to a facility
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Printer Status</returns>
        [HttpGet]
        [Route("Facility/{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(PrinterStatusResponseModel))]
        public HttpResponseMessage GetByItem(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new PrinterStatusResponseModel());
        }

        #endregion

        #region Print Jobs

        // GET /pts/printers/jobs?facility=XXXXX&status=Y&date=AAAAAA-BBBBBB – Gets print jobs based on search criteria
        /// <summary>
        /// Gets print jobs based on search criteria
        /// </summary>
        /// <param name="facility"></param>
        /// <param name="status"></param>
        /// <param name="date"></param>
        /// <param name="expand"></param>
        /// <returns>Printer Jobs</returns>
        [HttpGet]
        [Route("Jobs")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(PrinterJobResponseModel))]
        public HttpResponseMessage GetJobById(string facility, string status, string date, string expand = null)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new PrinterJobResponseModel());
        }

        // GET /pts/printers/jobs/{id} – Gets the number/content of pending jobs for the specified Printer
        /// <summary>
        /// Gets the number/content of pending jobs for the specified Printer
        /// </summary>
        /// <param name="id">Printer ID</param>
        /// <param name="expand"></param>
        /// <returns>Printer Jobs</returns>
        [HttpGet]
        [Route("Jobs/{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(PrinterJobResponseModel))]
        public HttpResponseMessage GetJobById(int id, string expand = null)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new PrinterJobResponseModel());
        }

        // GET /pts/printers/jobs/facility/{id} – Gets the number of pending jobs for the specified Facility
        /// <summary>
        /// Gets the number of pending jobs for the specified Facility
        /// </summary>
        /// <param name="id"></param>
        /// <param name="expand"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("Jobs/{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(PrinterJobResponseModel))]
        public HttpResponseMessage GetByCustomer(string id, string expand = null)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new PrinterJobResponseModel());
        }

        #endregion

        #region Close Print Jobs

        // POST /pts/printers/job/{id} – Update the status of a single print job
        /// <summary>
        /// Update the status of a single print job
        /// </summary>
        /// <param name="id">Printer ID</param>
        /// <param name="request">Close Printer Job Response</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Jobs/{id}")]
        [SwaggerResponse(HttpStatusCode.OK, Type = typeof(ClosePrintJobResponseModel))]
        public HttpResponseMessage ClosePrintJob(string id, ClosePrintJobRequestModel request)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new ClosePrintJobResponseModel());
        }

        #endregion
    }
}
