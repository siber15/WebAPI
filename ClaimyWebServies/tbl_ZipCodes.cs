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
    
    public partial class tbl_ZipCodes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ZipCodes()
        {
            this.tbl_Claims = new HashSet<tbl_Claims>();
            this.tbl_ParkingCompanies = new HashSet<tbl_ParkingCompanies>();
        }
    
        public int fld_ZipCode { get; set; }
        public string fld_City { get; set; }
        public int fld_CountryID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Claims> tbl_Claims { get; set; }
        public virtual tbl_Countries tbl_Countries { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ParkingCompanies> tbl_ParkingCompanies { get; set; }
    }
}