using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models.Action
{
    public class LoadRequestModel : IModelBase
    {
        [Required]
        public List<int> Items { get; set; }

        public int Truck { get; set; }

        public bool Close { get; set; }
    }

    public class LoadResponseModel : IModelBase
    {
        public List<Item> Items { get; set; }

        public int Total { get; set; }

        public string Dest { get; set; }

        public string Truck { get; set; }

        public string Status { get; set; }
    }
}