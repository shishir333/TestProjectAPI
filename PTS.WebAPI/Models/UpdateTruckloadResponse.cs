using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PTS.Business.Domain;

namespace PTS.WebAPI.Models
{
    public class UpdateTruckloadResponseModel : IModelBase
    {
        public string Id { get; set; }
        
        public string BatchStatus { get; set; }
        
        public int Total { get; set; }
        
        public int MissingCount { get; set; }
        
        public int DamageCount { get; set; } 
    }
}