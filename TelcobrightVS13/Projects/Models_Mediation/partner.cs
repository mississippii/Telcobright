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
    
    public partial class partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public partner()
        {
            this.accounts = new HashSet<account>();
            this.accounts1 = new HashSet<account>();
            this.bridgedroutes = new HashSet<bridgedroute>();
            this.bridgedroutes1 = new HashSet<bridgedroute>();
            this.ratetaskassigns = new HashSet<ratetaskassign>();
            this.routes = new HashSet<route>();
        }
    
        public int idPartner { get; set; }
        public string PartnerName { get; set; }
        public string AlternateNameInvoice { get; set; }
        public string AlternateNameOther { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Telephone { get; set; }
        public string email { get; set; }
        public int CustomerPrePaid { get; set; }
        public int PartnerType { get; set; }
        public Nullable<int> billingdate { get; set; }
        public Nullable<int> AllowedDaysForInvoicePayment { get; set; }
        public Nullable<int> timezone { get; set; }
        public Nullable<System.DateTime> date1 { get; set; }
        public Nullable<int> field1 { get; set; }
        public Nullable<int> field2 { get; set; }
        public Nullable<int> field3 { get; set; }
        public string field4 { get; set; }
        public string field5 { get; set; }
        public Nullable<float> refasr { get; set; }
        public Nullable<float> refacd { get; set; }
        public Nullable<float> refccr { get; set; }
        public Nullable<float> refccrbycc { get; set; }
        public Nullable<float> refpdd { get; set; }
        public Nullable<float> refasrfas { get; set; }
        public int DefaultCurrency { get; set; }
        public string invoiceAddress { get; set; }
        public string vatRegistrationNo { get; set; }
        public string paymentAdvice { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<account> accounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<account> accounts1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bridgedroute> bridgedroutes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<bridgedroute> bridgedroutes1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ratetaskassign> ratetaskassigns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<route> routes { get; set; }
    }
}
