using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Domain.Entities
{
    public class PaymentMethod
    {
        public Guid PaymentMethodId { get; set; }
        
        [Required]
        public string Name { get; set; } = string.Empty; // "PIX", "TED", "DOC", "Saque", etc.
        
        public string Description { get; set; } = string.Empty;
        
        public decimal? Fee { get; set; } // Taxa da operação
        
        public decimal? MinAmount { get; set; } // Valor mínimo
        
        public decimal? MaxAmount { get; set; } // Valor máximo
        
        public bool IsActive { get; set; } = true;
        
        public PaymentMethodType Type { get; set; }

        // Relacionamento com AccountPaymentMethod (1:N)
        public virtual ICollection<AccountPaymentMethod> AccountPaymentMethods { get; set; } = new List<AccountPaymentMethod>();

        // Relacionamento com Transactions (1:N)
        public virtual ICollection<Transactions> Transactions { get; set; } = new List<Transactions>();
    }
    
    public enum PaymentMethodType
    {
        InstantTransfer, // PIX
        BankTransfer,    // TED/DOC
        BankSlip,        // Boleto
        DebitCard,       // Cartão de débito
        AutomaticDebit,  // Débito automático
    }
}