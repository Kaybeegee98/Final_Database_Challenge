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
    
    public partial class C7602Interest
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public C7602Interest()
        {
            this.C7602Customer = new HashSet<C7602Customer>();
        }
    
        public string InterestCode { get; set; }
        public string InterestDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<C7602Customer> C7602Customer { get; set; }

        public C7602Interest(string interestCode, string interestDescription)
        {
            this.InterestCode = interestCode;
            this.InterestDescription = interestDescription;
        }
    }
}
