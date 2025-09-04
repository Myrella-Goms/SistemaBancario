using System;

namespace SistemaBancario.Domain.Entities
{
    public class SavingAccount : Account
    {
        public double TransferLimit { get; set; }
        public double Yield { get; set; }
        public float ReferenceRate { get; set; }
        public double Selic { get; set; }
    }
}
