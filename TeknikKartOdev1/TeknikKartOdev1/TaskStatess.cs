//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TeknikKartOdev1
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaskStatess
    {
        public int TaskStatesID { get; set; }
        public Nullable<int> TaskID { get; set; }
        public Nullable<int> DurumID { get; set; }
        public string Notlar { get; set; }
        public Nullable<System.DateTime> TaskStateDate { get; set; }
        public Nullable<int> userID { get; set; }
    
        public virtual Durumlar Durumlar { get; set; }
        public virtual Tasks Tasks { get; set; }
        public virtual Users Users { get; set; }
    }
}
