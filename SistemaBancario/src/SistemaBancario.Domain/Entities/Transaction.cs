using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Domain.Entities
{
    public class Transaction
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
        public DateTime CreatedAt { get; set; }
        
        public Guid? DestinationAccountId { get; set; } 
        public virtual Account? Account { get; set; }
        public virtual Account? DestinationAccount { get; set; }
    }
    public enum TransactionType
    {
        Deposit,
        Withdrawal,
        Transfer,
        Interest 
    }
}