//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _16012775_CLDV_POE
{
    using System;
    using System.Collections.Generic;
    
    public partial class MATERIAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MATERIAL()
        {
            this.MATERIALS_PER_PROJECT = new HashSet<MATERIALS_PER_PROJECT>();
        }
    
        public int MAT_ID { get; set; }
        public string MAT_TYPE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MATERIALS_PER_PROJECT> MATERIALS_PER_PROJECT { get; set; }
    }
}
