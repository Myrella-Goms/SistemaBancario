using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Domain.Entities
{
    public class CorporateClient : Client
    {
        [Required]
        public string CNPJ { get; set; } = string.Empty;
        [Required]
        public string CompanyName { get; set; } = string.Empty;
        public string StateRegistration { get; set; } = string.Empty;

    }
}