//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CelibateMusicAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class C7602Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C7602Customer()
        {
            this.C7602Sale = new HashSet<C7602Sale>();
        }
    
        public int CustomerNumber { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Postcode { get; set; }
        public string InterestCode { get; set; }
    
        public virtual C7602Interest C7602Interest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C7602Sale> C7602Sale { get; set; }
    }
}
