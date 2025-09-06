using System;
using System.Collections.Generic;

namespace SistemaBancario.Domain.Entities
{
    /// <summary>
    /// Define os métodos de pagamento padrão disponíveis para cada tipo de conta
    /// </summary>
    public static class AccountTypePaymentMethods
    {
        /// <summary>
        /// Métodos de pagamento disponíveis para Conta Corrente
        /// </summary>
        public static readonly List<string> CheckingAccountMethods = new()
        {
            "PIX",
            "TED", 
            "DOC",
            "Saque",
            "Depósito",
            "Consulta de Saldo",
            "Transferência",
            "Débito Automático",
            "Cartão de Débito"
        };

        /// <summary>
        /// Métodos de pagamento disponíveis para Conta Poupança
        /// </summary>
        public static readonly List<string> SavingsAccountMethods = new()
        {
            "PIX",
            "Consulta de Saldo",
            "Transferência", // Limitada a 5 por mês
            "Depósito"
        };

        /// <summary>
        /// Configurações específicas por tipo de conta
        /// </summary>
        public static class Configurations
        {
            public static class CheckingAccount
            {
                public static readonly decimal PIX_MAX_AMOUNT = 1000m; // Exemplo: limite PIX conta corrente
                public static readonly decimal TED_MIN_AMOUNT = 1m;
                public static readonly decimal TED_FEE = 15.90m;
            }

            public static class SavingsAccount  
            {
                public static readonly decimal PIX_MAX_AMOUNT = 500m; // Exemplo: limite menor para poupança
                public static readonly int MAX_MONTHLY_TRANSFERS = 5; // Limite legal
                public static readonly decimal TRANSFER_FEE_AFTER_LIMIT = 6.50m;
            }
        }
    }
}
