//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FieldOrder.DataAccessLayer.Context
{
    using System;
    using System.Collections.Generic;
    
    public partial class WEC_OUTBOUND_EVENT_TRIGGERS
    {
        public int ID { get; set; }
        public string AGENCY { get; set; }
        public string XPATH { get; set; }
        public string EVENT_TYPE { get; set; }
        public System.DateTime START_DATETIME { get; set; }
        public Nullable<System.DateTime> END_DATETIME { get; set; }
    }
}