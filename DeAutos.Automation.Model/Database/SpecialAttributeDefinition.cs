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
    public partial class SpecialAttributeDefinition
    {
        public SpecialAttributeDefinition()
        {
            this.Vehicles = new HashSet<Vehicle>();
        }
    
        public int Id { get; set; }
        public string KeyString { get; set; }
        public Nullable<bool> SavingPlanFeature { get; set; }
    
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}