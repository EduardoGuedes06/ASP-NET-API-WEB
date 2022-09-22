using AutoMapper;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;
using MinhaApiCompleta.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MinhaApiCompleta.Controllers
{
    [ApiController]
    public abstract class MainController : ControllerBase
    {
        // Validação de notificação de erro

        // validação de modelstate

        // validação de operação
       
    }
    [Route("Fornecedores")]
    public class FornecedorController : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public FornecedorController(IFornecedorRepository fornecedorRepository,IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        public IFornecedorRepository Get_fornecedorRepository()
        {
            return _fornecedorRepository;
        }

        public async Task<IEnumerable<FornecedorViewModel>>ObterTodos(IFornecedorRepository _fornecedorRepository)
        {
            var fornecedor = _mapper.Map<IEnumerable<FornecedorViewModel>> (await _fornecedorRepository.ObterTodos());
            return fornecedor;
        }
    }
}
