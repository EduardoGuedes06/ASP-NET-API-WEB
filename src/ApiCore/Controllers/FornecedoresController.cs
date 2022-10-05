using ApiCore.ViewModels;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore.Controllers
{
    [Route("api/fornecedores")]
    public class FornecedoresController : HomeController
    {
        private readonly IFornecedorRepository _fornecedorRepository;

        public FornecedoresController(IFornecedorRepository fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> ObterTodos()
        {

            var fornecedor = await _fornecedorRepository.ObterTodos();

            return Ok(fornecedor);
        }
    }
}
