//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace DeAutos.Automation.Model.Database
{
    public partial class PublicationPaperDate
    {
        public PublicationPaperDate()
        {
            this.AuditPublicationPaperDates = new HashSet<AuditPublicationPaperDate>();
        }
    
        public int P_Id { get; set; }
        public Nullable<int> F_PublicationPaper_Id { get; set; }
        public string A_State { get; set; }
        public DateTime A_OriginalPublishingDate { get; set; }
        public Nullable<int> F_PublicationPaperDateProcess_Id { get; set; }
    
        public virtual ICollection<AuditPublicationPaperDate> AuditPublicationPaperDates { get; set; }
        public virtual PublicationPaper PublicationPaper { get; set; }
        public virtual PublicationPaperDateProcess PublicationPaperDateProcess { get; set; }
    }
}
