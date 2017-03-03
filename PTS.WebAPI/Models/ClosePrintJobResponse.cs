using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PTS.WebAPI.Models
{
    public class ClosePrintJobResponseModel : IModelBase
    {
        public Guid Id { get; set; }

        public string Printer { get; set; }

        public string Facility { get; set; }

        public string Status { get; set; }
    }

    public class ClosePrintJobRequestModel : IModelBase
    {
        public bool Success { get; set; }

        public string Error { get; set; }

        public int Code { get; set; }
    }
}