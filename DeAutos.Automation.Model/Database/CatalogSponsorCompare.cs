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
    public partial class CatalogSponsorCompare
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
        public int SponsorId { get; set; }
    
        public virtual CatalogSponsor CatalogSponsor { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
    }
}
