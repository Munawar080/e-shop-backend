using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using E_ShopBackend.DTO_s;
namespace E_ShopBackend.Models
{
    public class ModelsMapping: Profile
    {
        public ModelsMapping()
        {
            CreateMap<Categories, CategoriesDTO>().ForMember(dest => dest.Id, src => src.Ignore());
        }
    }
}