//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PetParadise.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PetProfile
    {
        public string Id { get; set; }
        public string OwnerId { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Birthdate { get; set; }
        public string Color { get; set; }
        public string Line { get; set; }
        public string Barangay { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Nullable<int> Followers { get; set; }
        public Nullable<int> Following { get; set; }
        public string Category { get; set; }
        public string Breed { get; set; }
        public string Contact { get; set; }
        public string ContactId { get; set; }
    }
}
