using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Domain.Entities
{
    public class Client
    {
        public Guid ClientId { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string DocumentNumber { get; set; } = string.Empty;
        [Required]
        public DateOnly BirthDate { get; set; } 
        [Required]
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}