//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;

namespace DeAutos.Automation.Model.Database
{
    public partial class EMailAudit
    {
        public int Id { get; set; }
        public string OldEMail { get; set; }
        public string NewEMail { get; set; }
        public string State { get; set; }
        public DateTime SendDate { get; set; }
        public Nullable<DateTime> ConfirmationDate { get; set; }
        public string Action { get; set; }
        public int idUser { get; set; }
    
        public virtual User User { get; set; }
    }
}
