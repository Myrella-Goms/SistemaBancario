using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Domain.Entities
{
    public class AccountPaymentMethod
    {
        public Guid AccountPaymentMethodId { get; set; }

        [Required]
        public Guid AccountId { get; set; }

        [Required]
        public Guid PaymentMethodId { get; set; }

        public bool IsEnabled { get; set; } = true;

        public decimal? CustomFee { get; set; } 

        public decimal? CustomMinAmount { get; set; } 

        public decimal? CustomMaxAmount { get; set; } 

        public DateTime EnabledAt { get; set; } = DateTime.Now;
        public virtual Account Account { get; set; } = null!;
    }
}
