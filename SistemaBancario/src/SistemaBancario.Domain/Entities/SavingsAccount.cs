using System;

namespace SistemaBancario.Domain.Entities
{
    public class SavingsAccount : Account
    {
        public decimal TransferLimit { get; set; }
        public decimal Yield { get; set; }
        public decimal ReferenceRate { get; set; }
        public decimal Selic { get; set; }
        public int MonthlyTransferCount { get; set; }
        public int MaxMonthlyTransfers { get; set; } = 5; // Limite legal da poupança
    }
}
