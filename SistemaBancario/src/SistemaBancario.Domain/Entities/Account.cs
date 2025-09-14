using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBancario.Domain.Entities
{
    public abstract class Account
    {
        public Guid AccountId { get; set; }
        [Required]
        public string AccountNumber { get; set; } = string.Empty;
        [Required]
        public string Agency { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        [Required]
        [ForeignKey("Client")]
        public Guid ClientId { get; set; }
        public virtual Client? Client { get; set; }
        public virtual AccountBalance? AccountBalance { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();
        public virtual ICollection<Transactions> DestinationTransactions { get; set; } = new List<Transactions>();
  
    }
}
