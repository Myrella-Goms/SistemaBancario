using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        // Relacionamento com Client (N:1)
        [Required]
        public Guid ClientId { get; set; }
        public virtual Client Client { get; set; } = null!;

        // Relacionamento com AccountBalance (1:1)
        public virtual AccountBalance? AccountBalance { get; set; }

        // Relacionamento com Transactions (1:N)
        public virtual ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();

        // Relacionamento para transações de destino (1:N)
        public virtual ICollection<Transactions> DestinationTransactions { get; set; } = new List<Transactions>();

        // Relacionamento com métodos de pagamento disponíveis (N:N)
        public virtual ICollection<AccountPaymentMethod> AccountPaymentMethods { get; set; } = new List<AccountPaymentMethod>();
    }
}
