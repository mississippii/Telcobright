//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediationModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class enumservicefamily
    {
        public int id { get; set; }
        public string ServiceName { get; set; }
        public string Description { get; set; }
        public Nullable<int> PartnerAssignNotNeeded { get; set; }
        public int ServiceCategory { get; set; }
        public Nullable<int> AccountingId { get; set; }
    
        public virtual enumservicecategory enumservicecategory { get; set; }
    }
}