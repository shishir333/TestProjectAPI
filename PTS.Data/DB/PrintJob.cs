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
    
    public partial class PrintJob
    {
        public string ID { get; set; }
        public string FACILITY_ID { get; set; }
        public string PRINTER_ID { get; set; }
        public string CREATE_DATE { get; set; }
        public string SENT_DATE { get; set; }
        public string PRINT_DATE { get; set; }
        public string CONTENTS { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
