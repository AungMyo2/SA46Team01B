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
    
    public partial class SportFacilityDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SportFacilityDetail()
        {
            this.BookingDetails = new HashSet<BookingDetail>();
        }
    
        public string SportFacilityID { get; set; }
        public string SportFacilityNo { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int Quota { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookingDetail> BookingDetails { get; set; }
        public virtual SportFacility SportFacility { get; set; }
    }
}
