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
    public partial class ListingSponsorVehicleBrand
    {
        public int Id { get; set; }
        public int VehicleBrandId { get; set; }
        public int ListingSponsorId { get; set; }
    
        public virtual ListingSponsor ListingSponsor { get; set; }
        public virtual VehicleBrand VehicleBrand { get; set; }
    }
}