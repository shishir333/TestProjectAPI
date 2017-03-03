using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models.Action
{
    public class DeliveredRequestModel : IModelBase
    {
        [Required]
        public List<int> Items { get; set; }

        public string Signer { get; set; }
    }

    public class DeliveredResponseModel : IModelBase
    {
        public int Total { get; set; }
    }
}