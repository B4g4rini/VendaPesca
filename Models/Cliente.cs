using System.ComponentModel.DataAnnotations;

namespace VendaPesca.Models
{
    public class Cliente
    {
        [Key]
        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF_CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public bool StatusAtivo { get; set; }
    }
}
