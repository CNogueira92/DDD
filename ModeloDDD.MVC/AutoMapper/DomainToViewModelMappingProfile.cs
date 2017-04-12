using AutoMapper;
using ModeloDDD.Domain.Entities;
using ModeloDDD.MVC.ViewModels;

namespace ModeloDDD.MVC.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public string ProfileName
        {
            get { return "DomainToViewModelMappingProfile"; }
        }

        protected void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<ClienteViewModel, Cliente>());
            Mapper.Initialize(cfg => cfg.CreateMap<ProdutosViewModel, Produtos>());
        }
    }
}