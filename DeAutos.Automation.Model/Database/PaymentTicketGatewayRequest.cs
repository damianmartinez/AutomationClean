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
    public partial class PaymentTicketGatewayRequest
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public int IdPurchaseOrder { get; set; }
        public int IdPaymentMethod { get; set; }
        public DateTime Date { get; set; }
        public string State { get; set; }
        public Nullable<DateTime> DateChangeState { get; set; }
    
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual User User { get; set; }
        public virtual PurchaseOrder PurchaseOrder { get; set; }
    }
}
