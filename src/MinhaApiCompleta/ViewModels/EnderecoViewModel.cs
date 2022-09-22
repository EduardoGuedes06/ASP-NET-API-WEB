using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MinhaApiCompleta.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Logradouro { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Numero { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Complemento { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Cidade{ get; set; }
        [Required(ErrorMessage = "O campo {0} é obrigatorio")]
        public string Estado { get; set; }
  
        public Guid FornecedorId { get; set; }
        
    }
}
