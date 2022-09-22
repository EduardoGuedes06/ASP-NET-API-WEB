using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DevIO.Business.Intefaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MinhaApiCompleta.Controllers;
using MinhaApiCompleta.ViewModels;

namespace MinhaApiTeste.Controllers
{
    [Route("Fornecedores")]
    [ApiController]
    public class FornecedoresController : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IMapper _mapper;

        public FornecedoresController(IFornecedorRepository fornecedorRepository, IMapper mapper)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
        }

        public IFornecedorRepository Get_fornecedorRepository()
        {
            return _fornecedorRepository;
        }

        public async Task<IEnumerable<FornecedorViewModel>> ObterTodos(IFornecedorRepository _fornecedorRepository)
        {
            var fornecedor = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());
            return fornecedor;
        }
    }
}
