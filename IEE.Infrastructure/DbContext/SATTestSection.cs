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
    
    public partial class SATTestSection
    {
        public int ID { get; set; }
        public int TestID { get; set; }
        public int TotalRightAnswer { get; set; }
        public int ScoreID { get; set; }
        public int Section { get; set; }
        public System.DateTime StartTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public System.Guid rowguid { get; set; }
        public bool Status { get; set; }
    
        public virtual SATExamForm SATExamForm { get; set; }
        public virtual SATScore SATScore { get; set; }
        public virtual SATTest SATTest { get; set; }
    }
}
