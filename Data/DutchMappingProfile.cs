using AutoMapper;
using DutchGo.Data.Entities;
using DutchGo.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchGo.Data
{
    public class DutchMappingProfile : Profile
    {
        public DutchMappingProfile()
        {
            CreateMap<Order, OrderViewModel>()
                .ForMember(o => o.OrderId, ex => ex.MapFrom(o => o.Id))
                .ReverseMap();

            CreateMap<OrderItem, OrderItemViewModel>()
                .ReverseMap();
        }
        
    }
}
