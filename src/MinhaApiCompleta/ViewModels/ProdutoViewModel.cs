using System;
using System.ComponentModel.DataAnnotations;

namespace MinhaApiCompleta.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id{ get; set; }
        public Guid FornecedorId { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Descricao { get; set; }
        public string ImagemUpload { get; set; }
        public string Imagem { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        [ScaffoldColumn(false)]
        public String NomeFornecedor { get; set; }
    }
}
