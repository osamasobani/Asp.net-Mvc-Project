//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMS.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Manager
    {
        public int Id { get; set; }

        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Name Name connont exceed 20 letters")]
        public string Name { get; set; }
    }
}