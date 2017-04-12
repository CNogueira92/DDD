using AutoMapper;
using ModeloDDD.Domain.Entities;
using ModeloDDD.MVC.ViewModels;

namespace ModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile :Profile
    {
        public  string ProfileName
        {
            get { return "ViewModelToDomainMappingProfile"; }
        }

        protected void Configure()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Cliente, ClienteViewModel>());
            Mapper.Initialize(cfg => cfg.CreateMap<Produtos, ProdutosViewModel>());            
        }
    }
}