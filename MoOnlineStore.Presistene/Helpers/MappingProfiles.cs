using AutoMapper;
using MoOnlineStore.Core.DTO;
using MoOnlineStore.Core.EntityClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoOnlineStore.Presistene.Helpers
{
  public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Products, DTOProducts>()
             .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
            .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
            .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
             CreateMap<ProductBrand, DTOProductBrand>();
              CreateMap<ProductType, DTOProductType>();
        }
    }
}
