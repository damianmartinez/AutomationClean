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
    public partial class LocationType
    {
        public LocationType()
        {
            this.Locations = new HashSet<Location>();
        }
    
        public int P_Id { get; set; }
        public string A_Description { get; set; }
    
        public virtual ICollection<Location> Locations { get; set; }
    }
}
