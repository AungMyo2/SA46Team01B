//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA46Team01B
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookingDetail
    {
        public string BookingNo { get; set; }
        public string SportFacilityID { get; set; }
        public System.DateTime BookingDate { get; set; }
        public string SessionNo { get; set; }
        public decimal Amount { get; set; }
    
        public virtual Booking Booking { get; set; }
        public virtual Session Session { get; set; }
        public virtual SportFacilityDetail SportFacilityDetail { get; set; }
    }
}
