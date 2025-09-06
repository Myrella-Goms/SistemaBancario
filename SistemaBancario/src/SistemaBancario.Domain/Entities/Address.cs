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
        public string StreetName { get; set; } = string.Empty;
        [Required]
        public string Neighborhood { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public string State { get; set; } = string.Empty;
        [Required]
        public string ZipCode { get; set; } = string.Empty;
        public string? Complement { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
    }
}