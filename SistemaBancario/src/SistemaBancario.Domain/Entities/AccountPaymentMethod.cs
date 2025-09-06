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

        public decimal? CustomFee { get; set; } // Taxa personalizada para esta conta

        public decimal? CustomMinAmount { get; set; } // Limite mínimo personalizado

        public decimal? CustomMaxAmount { get; set; } // Limite máximo personalizado

        public DateTime EnabledAt { get; set; } = DateTime.Now;

        // Relacionamentos de navegação
        public virtual Account Account { get; set; } = null!;
        public virtual PaymentMethod PaymentMethod { get; set; } = null!;
    }
}
