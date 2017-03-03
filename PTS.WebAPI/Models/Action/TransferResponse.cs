using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models.Action
{
    public class TransferRequestModel : IModelBase
    {
        [Required]
        public List<int> Items { get; set; }

        public string Location { get; set; }
    }

    public class TransferResponseModel : IModelBase
    {
        public int Total { get; set; }

        public string From { get; set; }

        public string To { get; set; }
    }
}