using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models
{
    public class TruckloadResponseModel : IModelBase
    {
        public string Id { get; set; }
        
        public string Driver { get; set; }
        
        public List<Item> Items { get; set; }
        
        public string Dest { get; set; }
        
        public string Status { get; set; } 
    }
}