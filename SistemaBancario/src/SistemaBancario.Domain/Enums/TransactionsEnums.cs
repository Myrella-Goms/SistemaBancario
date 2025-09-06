using System;

namespace SistemaBancario.Domain.Enums
{
    public enum TransactionType
    {
        Deposit,    // Depósito
        Withdrawal, // Saque
        Transfer,   // Transferência
        Pix,        // PIX
        Ted,        // TED
        Doc,        // DOC
        Interest,   // Juros/Rendimento
        Fee,        // Taxa
        Payment     // Pagamento
    }
}