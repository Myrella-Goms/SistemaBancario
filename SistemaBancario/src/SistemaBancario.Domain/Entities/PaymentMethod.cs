using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Domain.Entities
{
    public class PaymentMethod
    {
        public Guid PaymentMethodId { get; set; }
        
        [Required]
        public string Name { get; set; } // "PIX", "Boleto", "TED"
        
        public string Description { get; set; }
        
        public decimal? Fee { get; set; } // Taxa da operação
        
        public decimal? MinAmount { get; set; } // Valor mínimo
        
        public decimal? MaxAmount { get; set; } // Valor máximo
        
        public bool IsActive { get; set; } = true;
        
        public PaymentMethodType Type { get; set; }
    }
    
    public enum PaymentMethodType
    {
        InstantTransfer, // PIX
        BankTransfer,    // TED/DOC
        BankSlip,        // Boleto
        DebitCard,       // Cartão de débito
        AutomaticDebit   // Débito automático
    }
}