using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models.Action
{
    public class DamageRequestModel : IModelBase
    {
        [Required]
        public List<int> Items { get; set; }

        public int Code { get; set; }

        public string Notes { get; set; }

        public string Image { get; set; }

        public string Image2 { get; set; }

        public string Image3 { get; set; }
    }

    public class DamageResponseModel : IModelBase
    {
        public string Url { get; set; }

        public int Total { get; set; }
    }
}