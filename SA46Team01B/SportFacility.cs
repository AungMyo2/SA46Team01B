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
    
    public partial class SportFacility
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SportFacility()
        {
            this.SportFacilityDetails = new HashSet<SportFacilityDetail>();
        }
    
        public string SportFacilityNo { get; set; }
        public string SportFacilityName { get; set; }
        public decimal PricePerHour { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SportFacilityDetail> SportFacilityDetails { get; set; }
    }
}
