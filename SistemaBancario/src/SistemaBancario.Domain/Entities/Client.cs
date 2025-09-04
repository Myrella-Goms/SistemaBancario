using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Domain.Entities
{
    public abstract class Client
    {
        public Guid ClientId { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateOnly BirthDate { get; set; }
        [Required]
        public string Phone { get; set; } = string.Empty;
        [Required]  
        public string Email { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}