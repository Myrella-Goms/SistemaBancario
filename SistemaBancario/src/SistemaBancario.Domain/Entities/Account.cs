using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Domain.Entities
{
    public abstract class Account
    {
        public Guid AccountId { get; set; }
        [Required]
        public string AccountNumber { get; set; }
        [Required]
        public string Agency { get; set; }
        public string Password { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
