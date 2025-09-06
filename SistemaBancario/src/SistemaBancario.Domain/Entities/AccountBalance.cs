using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Domain.Entities
{
    public class AccountBalance
    {
        public Guid AccountBalanceId { get; set; }
        
        [Required]
        public Guid AccountId { get; set; }
        
        [Required]
        public decimal CurrentBalance { get; set; }
        
        public decimal AvailableBalance { get; set; }
        
        public decimal BlockedAmount { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; } = DateTime.Now;
        public virtual Account Account { get; set; } = null!;
    }
}