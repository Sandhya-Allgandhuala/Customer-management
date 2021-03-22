using AutoMapper;
using PM_Model;
using PM_Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PM_Services
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Customer, CustomerDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Sales, SalesDTO>().ReverseMap();
            CreateMap<Store, StoreDTO>().ReverseMap();
        }
    }
}
