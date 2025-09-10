using System;
using Microsoft.EntityFrameworkCore;
using SistemaBancario.Domain.Entities;

namespace SistemaBancario.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountBalance> AccountBalances { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<CheckingAccount> CheckingAccounts { get; set; }
        public DbSet<SavingsAccount> SavingsAccounts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<CorporateClient> CorporateClients { get; set; }
        public DbSet<PersonalClient> PersonalClients { get; set; }
        public DbSet<Transactions> Transactions { get; set; }

    }

}