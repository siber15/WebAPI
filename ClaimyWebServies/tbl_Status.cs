//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClaimyWebServies
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Status
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Status()
        {
            this.tbl_ClaimHistory = new HashSet<tbl_ClaimHistory>();
        }
    
        public int fld_StatusID { get; set; }
        public string fld_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ClaimHistory> tbl_ClaimHistory { get; set; }
    }
}
