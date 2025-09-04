using System;

namespace SistemaBancario.Domain.Entities
{
    public class CheckingAccount : Account
    {
        public double Taxes { get; set; }
        public double Balance { get; set; }
    }
}
