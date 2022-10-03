using AutoMapper;
using DevIO.Api.ViewModels;
using DevIO.Business.Intefaces;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiCore.Controllers
{
    [Route("api/fornecedores")]
    public class FornecedorController : MainController
    {
        private readonly IFornecedorRepository _fornecedorRepository;
        private readonly IFornecedorService _fornecedorService;
        private readonly IMapper _mapper;
        public FornecedorController(IFornecedorRepository fornecedorRepository, IMapper mapper, IFornecedorService fornecedorService)
        {
            _fornecedorRepository = fornecedorRepository;
            _mapper = mapper;
            _fornecedorService = fornecedorService;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<FornecedorViewModel>>> ObterTodos()
        {
            var fornecedor = _mapper.Map<IEnumerable<FornecedorViewModel>>(await _fornecedorRepository.ObterTodos());
            return Ok(fornecedor);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<FornecedorViewModel>> ObterPorId(Guid id)
        {
            var fornecedor = await ObterFornecedorProdutosEndereço(id);

            if(fornecedor == null) return NotFound();

            return fornecedor;
        }

        [HttpPost]

        public async Task<ActionResult<FornecedorViewModel>> Adicionar (FornecedorViewModel fornecedorViewModel)
        {
            if (!ModelState.IsValid) 
                return BadRequest();

            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);
            await _fornecedorService.Adicionar(fornecedor);

            return Ok(fornecedor);
        }

        [HttpPut("{id:guid}")]

        public async Task<ActionResult<FornecedorViewModel>> Atualizar(Guid id,FornecedorViewModel fornecedorViewModel)
        {
            if (id != fornecedorViewModel.Id) return BadRequest();
            if (!ModelState.IsValid) return BadRequest();

            var fornecedor = _mapper.Map<Fornecedor>(fornecedorViewModel);
            await _fornecedorService.Atualizar(fornecedor);

            return Ok(fornecedor);
        }

        [HttpDelete("{id:guid}")]

        public async Task<ActionResult<FornecedorViewModel>> Excluir(Guid id)
        {
            var fornecedor = await ObterFornecedorEndereço(id);

            if(fornecedor == null ) return NotFound();

           var result = await _fornecedorService.Remover(id); 

            if(!result) return BadRequest();

            return Ok(fornecedor);
        }
        public async Task<FornecedorViewModel> ObterFornecedorProdutosEndereço(Guid id)
        {
           return _mapper.Map<FornecedorViewModel>(await _fornecedorRepository.ObterFornecedorProdutosEndereco(id));

        }

        public async Task<FornecedorViewModel> ObterFornecedorEndereço(Guid id)
        {
            return _mapper.Map<FornecedorViewModel>(await _fornecedorRepository.ObterFornecedorEndereco(id));

        }

    }
}