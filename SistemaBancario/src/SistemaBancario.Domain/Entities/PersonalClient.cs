using System.ComponentModel.DataAnnotations;

namespace SistemaBancario.Domain.Entities
{
    public class PersonalClient : Client
    {
        [Required]
        public string CPF { get; set; } = string.Empty;
        [Required]
        public string RG { get; set; } = string.Empty;

    }
}