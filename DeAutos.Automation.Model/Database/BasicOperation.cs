//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Collections.Generic;

namespace DeAutos.Automation.Model.Database
{
    public partial class BasicOperation
    {
        public BasicOperation()
        {
            this.AuditCatalogs = new HashSet<AuditCatalog>();
        }
    
        public long P_id { get; set; }
        public string A_Description { get; set; }
    
        public virtual ICollection<AuditCatalog> AuditCatalogs { get; set; }
    }
}
