﻿using AutoMapper;
using DevIO.App.Models;
using DevIO.App.ViewModels;
using DevIO.Business.Models;

namespace DevIO.App.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
