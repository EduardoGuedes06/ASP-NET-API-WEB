using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MinhaApiCompleta.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Name { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Documento { get; set; }
        public int TipoFornecedor { get; set; }
        public int TEndereco { get; set; }
        public Boolean Ativo { get; set; }
        public IEnumerable<ProdutoViewModel> Produtos { get; set; }
    }
}
