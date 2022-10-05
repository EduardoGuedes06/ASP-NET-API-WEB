using ApiCore.ViewModel;
using ApiCore.ViewModels;
using AutoMapper;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiCore.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
