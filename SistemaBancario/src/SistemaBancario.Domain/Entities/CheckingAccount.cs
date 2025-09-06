using System;

namespace SistemaBancario.Domain.Entities
{
    public class CheckingAccount : Account
    {
        public decimal Taxes { get; set; }
        public decimal OverdraftLimit { get; set; }
        public decimal OverdraftInterestRate { get; set; }
    }
}
