using System;
using System.ComponentModel.DataAnnotations;
using SistemaBancario.Domain.Enums;

namespace SistemaBancario.Domain.Entities
{
    public class Transactions
    {
        public Guid TransactionId { get; set; }
        
        [Required]
        public Guid AccountId { get; set; } 
        
        [Required]
        public decimal Amount { get; set; }
        
        [Required]
        public TransactionType Type { get; set; }
        
        public string? Description { get; set; }
        
        [Required]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public Guid? DestinationAccountId { get; set; }
        public virtual Account Account { get; set; } = null!;
        public virtual Account? DestinationAccount { get; set; }
    }
}