using AutoMapper;
using RestaurantAPI.Entities.Models;
using RestaurantAPI.Profiles.Dto;

namespace RestaurantAPI.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Order, OrderDto>().ReverseMap();
            CreateMap<Booking, BookingDto>().ReverseMap();
            CreateMap<BillDetail, BillDetailDto>().ReverseMap();
            CreateMap<Customer, CustomerDto>().ReverseMap();
            CreateMap<EmpList, EmpListDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Food, FoodDto>().ReverseMap();
            CreateMap<Item, ItemDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();
            CreateMap<MenuTable, MenuTableDto>().ReverseMap();
            CreateMap<ResMenu, ResMenuDto>().ReverseMap();
            CreateMap<SellDetail, SellDetailDto>().ReverseMap();
            CreateMap<TableDetail, TableDetailDto>().ReverseMap();
        
        }
    }
}