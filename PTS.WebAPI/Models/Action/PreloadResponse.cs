using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models.Action
{
    public class PreloadRequestModel : IModelBase
    {
        [Required]
        public List<int> Waybills { get; set; }

        public bool Force { get; set; }
    }

    public class PreloadResponseModel : IModelBase
    {
        public List<Waybill> Waybills { get; set; }

        public int Total { get; set; }
    }
}