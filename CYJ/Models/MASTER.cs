//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CYJ.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MASTER
    {
        public int masterID { get; set; }
        public Nullable<int> teamID { get; set; }
        public Nullable<int> wstreamID { get; set; }
        public Nullable<int> categID { get; set; }
        public Nullable<int> subcategID { get; set; }
        public Nullable<int> agoalID { get; set; }
        public Nullable<int> qonegoalID { get; set; }
        public Nullable<int> qtwogoalID { get; set; }
        public Nullable<int> qthreegoalID { get; set; }
        public Nullable<int> qfourgoalID { get; set; }
    
        public virtual AGOAL AGOAL { get; set; }
        public virtual CATEGORY CATEGORY { get; set; }
        public virtual QfourGOAL QfourGOAL { get; set; }
        public virtual QoneGOAL QoneGOAL { get; set; }
        public virtual QthreeGOAL QthreeGOAL { get; set; }
        public virtual QtwoGOAL QtwoGOAL { get; set; }
        public virtual SUBCATEGORY SUBCATEGORY { get; set; }
        public virtual TEAM TEAM { get; set; }
        public virtual WSTREAM WSTREAM { get; set; }
    }
}
