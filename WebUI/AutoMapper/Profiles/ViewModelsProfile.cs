using AutoMapper;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Areas.Admin.Models;

namespace WebUI.AutoMapper.Profiles
{
    public class ViewModelsProfile : Profile
    {
        public ViewModelsProfile()
        {
            CreateMap<ArticleAddViewModel, ArticleAddDto>();
            CreateMap<ArticleUpdateDto, ArticleUpdateViewModel>().ReverseMap();
        }
    }
}
