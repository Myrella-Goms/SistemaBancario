using System;
using System.Collections.Generic;
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
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        // Relacionamento com Address (1:1)
        public Guid? AddressId { get; set; }
        public virtual Address? Address { get; set; }

        // Relacionamento com Account (1:N)
        public virtual ICollection<Account> Accounts { get; set; } = new List<Account>();
    }
}