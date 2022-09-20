using System;
using System.ComponentModel.DataAnnotations;

namespace MinhaApi.Models
{
    public class Fornecedor
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Documento { get; set; }
        public int TipoFornecedor { get; set; }
        public Boolean Ativo { get; set; }
    }
}
