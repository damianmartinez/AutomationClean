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
    public partial class NewCar
    {
        public int Car_id { get; set; }
        public Nullable<decimal> AdvancePayment { get; set; }
        public Nullable<decimal> SinceQuota { get; set; }
        public Nullable<decimal> Patenting { get; set; }
    
        public virtual Car Car { get; set; }
    }
}