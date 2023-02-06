using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using E_ShopBackend.Models;
using E_ShopBackend.DTO_s;
namespace E_ShopBackend.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Categories, CategoriesDTO>();
            Mapper.CreateMap<CategoriesDTO, Categories>();
        }
    }
}