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
    public partial class SuscriptionItem
    {
        public int Id { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<int> Suscription_id { get; set; }
        public Nullable<int> ProductOfferingId { get; set; }
    
        public virtual ProductOffering ProductOffering { get; set; }
    }
}
