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
    public partial class CreditPackItem
    {
        public int Id { get; set; }
        public Nullable<int> CreditPackId { get; set; }
        public int ProductOfferingId { get; set; }
        public int Stock { get; set; }
        public int SpentStock { get; set; }
    
        public virtual CreditPack CreditPack { get; set; }
        public virtual ProductOffering ProductOffering { get; set; }
    }
}
