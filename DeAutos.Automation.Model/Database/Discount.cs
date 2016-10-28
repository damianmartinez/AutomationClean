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
    public partial class Discount
    {
        public Discount()
        {
            this.PurchaseOrderItemDiscounts = new HashSet<PurchaseOrderItemDiscount>();
            this.DiscountCoupons = new HashSet<DiscountCoupon>();
            this.GeoLocationItems = new HashSet<GeoLocationItem>();
            this.Products = new HashSet<Product>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int idBusinessDomain { get; set; }
        public bool Enabled { get; set; }
        public bool IsAutomatic { get; set; }
        public DateTime AvailableSinceDate { get; set; }
        public DateTime AvailableToDate { get; set; }
        public Nullable<int> DurationInDays { get; set; }
        public Nullable<int> idProduct { get; set; }
        public string CodeSap { get; set; }
        public bool AutoGenerateDiscountCouponCode { get; set; }
        public Nullable<DateTime> DueDateDiscountCoupon { get; set; }
        public bool IsCombined { get; set; }
        public decimal Percentage { get; set; }
        public string KeyString { get; set; }
    
        public virtual ICollection<PurchaseOrderItemDiscount> PurchaseOrderItemDiscounts { get; set; }
        public virtual BusinessDomain BusinessDomain { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<DiscountCoupon> DiscountCoupons { get; set; }
        public virtual ICollection<GeoLocationItem> GeoLocationItems { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}