//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IEE.Infrastructure.DbContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class SATScore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SATScore()
        {
            this.SATTestSections = new HashSet<SATTestSection>();
        }
    
        public int ID { get; set; }
        public int RawValue { get; set; }
        public int ScoreValue { get; set; }
        public int TypeID { get; set; }
    
        public virtual SATType SATType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SATTestSection> SATTestSections { get; set; }
    }
}
