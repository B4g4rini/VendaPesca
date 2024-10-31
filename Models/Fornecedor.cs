using System.ComponentModel.DataAnnotations;

namespace VendaPesca.Models
{
    public class Fornecedor
    {
        [Key]
        public Guid FornecedorId { get; set; }
        public string NomeEmpresa { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
    }
}
