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
    
    public partial class tbl_Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Users()
        {
            this.tbl_ClaimHistory = new HashSet<tbl_ClaimHistory>();
            this.tbl_Claims = new HashSet<tbl_Claims>();
        }
    
        public int fld_UserID { get; set; }
        public int fld_TypeID { get; set; }
        public string fld_Title { get; set; }
        public string fld_Fullname { get; set; }
        public string fld_Email { get; set; }
        public string fld_AuthKey { get; set; }
        public string fld_PasswordHash { get; set; }
        public System.DateTime fld_SignupTime { get; set; }
        public System.DateTime fld_LastAction { get; set; }
        public string fld_CustomerAddress { get; set; }
        public string fld_CustomerCountry { get; set; }
        public Nullable<bool> Avtive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ClaimHistory> tbl_ClaimHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Claims> tbl_Claims { get; set; }
        public virtual tbl_LoginType tbl_LoginType { get; set; }
    }
}