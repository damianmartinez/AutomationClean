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
    public partial class ListedVehicleFeatureValue
    {
        public long P_Id { get; set; }
        public Nullable<long> F_ListedVehiclesFeatures_Id { get; set; }
        public string A_Value { get; set; }
    
        public virtual ListedVehicleFeature ListedVehicleFeature { get; set; }
    }
}
