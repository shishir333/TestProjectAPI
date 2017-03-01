using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models
{
    public class FacilityResponseModel : IModelBase
    {
        public List<Facility> Facilities { get; set; }
    }
}