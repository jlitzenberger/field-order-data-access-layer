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
    
    public partial class WEC_METER_INSPECTION
    {
        public string ISR_NO { get; set; }
        public string METER_NUMBER { get; set; }
        public string SERVICE_ADDRESS { get; set; }
        public string METER_COMP_CODE { get; set; }
        public string METER_LOCATION { get; set; }
        public string METER_STATUS { get; set; }
        public string METER_BAR { get; set; }
        public Nullable<decimal> METER_READING { get; set; }
        public string LEAK_FOUND { get; set; }
        public string METER_CORROSION { get; set; }
        public string MTR_PIPE_SUP_COND { get; set; }
        public string MTR_PIPE_EXPOSURE { get; set; }
        public string METER_REMARKS { get; set; }
        public string PIPE_SUPPORT_COND { get; set; }
        public string PIPE_EXPOSURE { get; set; }
        public string PIPE_CORROSION { get; set; }
        public string HEEL_LEAK_FOUND { get; set; }
        public string HEEL_COMP_CODE { get; set; }
        public string HEEL_REMARKS { get; set; }
        public Nullable<decimal> ODORANT_READING { get; set; }
        public string ODRNT_DEV_SERL_NO { get; set; }
        public string ISI_JOBCODE { get; set; }
        public string ISI_WORKTYPE { get; set; }
        public Nullable<int> PIPEPREMISEID { get; set; }
        public Nullable<short> PIPEPREMISESERVICESEQNUM { get; set; }
        public int MOD_PERSONNEL_ID { get; set; }
        public System.DateTimeOffset MOD_DATETIME { get; set; }
    }
}
