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
    public partial class SourceConversation
    {
        public SourceConversation()
        {
            this.Conversations = new HashSet<Conversation>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Conversation> Conversations { get; set; }
    }
}
