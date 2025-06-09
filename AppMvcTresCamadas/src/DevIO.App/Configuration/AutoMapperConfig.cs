using AutoMapper;
using DevIO.App.Models;
using DevIO.Business.Models;

namespace DevIO.App.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Produto, ProdutoViewModel_old>().ReverseMap();
        }
    }
}
