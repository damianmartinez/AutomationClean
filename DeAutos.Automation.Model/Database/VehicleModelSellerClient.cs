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
    public partial class VehicleModelSellerClient
    {
        public long P_Id { get; set; }
        public int F_VehicleModel_Id { get; set; }
        public int F_User_Id { get; set; }
        public bool A_ActiveState { get; set; }
    
        public virtual ClientUser ClientUser { get; set; }
        public virtual VehicleModel VehicleModel { get; set; }
    }
}
