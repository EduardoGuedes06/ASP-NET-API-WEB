using AutoMapper;
using DevIO.Business.Models;
using Microsoft.AspNetCore.Mvc;
using MinhaApiCompleta.ViewModels;

namespace MinhaApiCompleta.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Fornecedor, EnderecoViewModel>().ReverseMap();
            CreateMap<Fornecedor, ProdutoViewModel>().ReverseMap();
        }
    }
}
