//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTS.Data.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public string EVENT_ID { get; set; }
        public string EVENT_TYPE { get; set; }
        public Nullable<int> TRUCKLOAD_ID { get; set; }
        public int WAYBILL_ID { get; set; }
        public int ITEM_ID { get; set; }
        public string SRC { get; set; }
        public string DEST { get; set; }
        public string IMAGE_URL { get; set; }
        public string NOTES { get; set; }
        public int PERSON_ID { get; set; }
        public string FACILITY_ID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}