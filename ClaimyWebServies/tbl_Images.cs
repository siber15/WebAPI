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
    
    public partial class tbl_Images
    {
        public int fld_ImagePath { get; set; }
        public int fld_ClaimID { get; set; }
    
        public virtual tbl_Claims tbl_Claims { get; set; }
    }
}