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
    
    public partial class WEC_SOAP_SERVICE_EXCEPTION_LOG
    {
        public long ID { get; set; }
        public string EXCEPTION_TYPE { get; set; }
        public string DESCRIPTION { get; set; }
        public byte[] STACKTRACE { get; set; }
        public System.DateTime EXCEPTION_DATETIME { get; set; }
        public string SERVICE_NAME { get; set; }
    }
}
