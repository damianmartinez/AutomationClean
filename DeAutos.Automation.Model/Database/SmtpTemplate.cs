//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeAutos.Automation.Model.Database
{
    public partial class SmtpTemplate
    {
        public int Id { get; set; }
        public string FromName { get; set; }
        public string FromAddress { get; set; }
        public string Body { get; set; }
    
        public virtual MessageTemplate MessageTemplate { get; set; }
    }
}
