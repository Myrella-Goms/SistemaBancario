using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaBancario.Domain.Entities
{
    public class AccountBalance
    {
        public Guid AccountBalanceId { get; set; }
        
        [ForeignKey("Account")]
        public Guid AccountId { get; set; }
        
        [Required]
        public decimal CurrentBalance { get; set; }
        
        public decimal AvailableBalance { get; set; }
        
        public decimal BlockedAmount { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; } = DateTime.Now;
        public virtual Account? Account { get; set; }
    }
}