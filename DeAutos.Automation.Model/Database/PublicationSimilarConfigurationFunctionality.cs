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
    public partial class PublicationSimilarConfigurationFunctionality
    {
        public PublicationSimilarConfigurationFunctionality()
        {
            this.PublicationSimilarConfigurations = new HashSet<PublicationSimilarConfiguration>();
        }
    
        public int P_Id { get; set; }
        public string A_Name { get; set; }
        public string A_MatchKey { get; set; }
    
        public virtual ICollection<PublicationSimilarConfiguration> PublicationSimilarConfigurations { get; set; }
    }
}
