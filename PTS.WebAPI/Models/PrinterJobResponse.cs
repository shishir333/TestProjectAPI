using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models
{
    public class PrinterJobResponseModel : IModelBase
    {
        public int Id { get; set; }

        public string Facility { get; set; }

        public int Count { get; set; }

        public List<Job> Jobs { get; set; }

        public List<PrinterStatus> Statuses { get; set; }
    }
}