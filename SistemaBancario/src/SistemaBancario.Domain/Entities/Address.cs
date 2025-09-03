using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Domain.Entities
{
    public class Address
    {
        public Guid AddressId { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public string StreetName { get; set; }
        [Required]
        public string Neighborhood { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string ZipCode { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}