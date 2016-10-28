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
    public partial class ListingSponsor
    {
        public ListingSponsor()
        {
            this.ListingSponsorGeoLocationItems = new HashSet<ListingSponsorGeoLocationItem>();
            this.ListingSponsorVehicleModelYears = new HashSet<ListingSponsorVehicleModelYear>();
            this.ListingSponsorVehicleBrands = new HashSet<ListingSponsorVehicleBrand>();
        }
    
        public int Id { get; set; }
        public Nullable<bool> Enabled { get; set; }
        public Nullable<int> User_Id { get; set; }
        public Nullable<int> PublicationOrder_Id { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<ListingSponsorGeoLocationItem> ListingSponsorGeoLocationItems { get; set; }
        public virtual ICollection<ListingSponsorVehicleModelYear> ListingSponsorVehicleModelYears { get; set; }
        public virtual ICollection<ListingSponsorVehicleBrand> ListingSponsorVehicleBrands { get; set; }
        public virtual Publication Publication { get; set; }
        public virtual User User { get; set; }
    }
}
