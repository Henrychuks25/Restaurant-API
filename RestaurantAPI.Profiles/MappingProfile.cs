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
            CreateMap<Employee, EmployeeDto>()
                //.ForMember(dest => dest.Address, opt => opt.MapFrom(src => $"{src.EAddress}"))
                //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => $"{src.EId}"))
                //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.EName}"))
                //.ForMember(dest => dest.Phone, opt => opt.MapFrom(src => $"{src.EPhone}"))
                //.ForMember(dest => dest.JobId, opt => opt.MapFrom(src => $"{src.JId}"))
                // Handle HashSet properties
                .ForMember(dest => dest.Foods, opt => opt.MapFrom(src => src.Foods.ToList()))
                .ForMember(dest => dest.MenuTables, opt => opt.MapFrom(src => src.MenuTables.ToList()))
                .ForMember(dest => dest.Orders, opt => opt.MapFrom(src => src.Orders.ToList())); 
            CreateMap<Food, FoodDto>()
                //.ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => $"{src.EId}"))
                //.ForMember(dest => dest.Id, opt => opt.MapFrom(src => $"{src.FId}"))
                //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => $"{src.FName}"))
                //.ForMember(dest => dest.Price, opt => opt.MapFrom(src => $"{src.FPrice}")
                //);
                .ReverseMap();
            CreateMap<Item, ItemDto>().ReverseMap();
            CreateMap<Job, JobDto>().ReverseMap();
            CreateMap<MenuTable, MenuTableDto>().ReverseMap();
            CreateMap<ResMenu, ResMenuDto>().ReverseMap();
            CreateMap<SellDetail, SellDetailDto>().ReverseMap();
            CreateMap<TableDetail, TableDetailDto>().ReverseMap();
            CreateMap<CreateFoodDto, Food>()
                        .ForMember(dest => dest.EmployeeId, opt => opt.MapFrom(src => $"{src.CreatedBy}"))

                .ReverseMap();

            CreateMap<CreateJobDto, Job>()
                        //.ForMember(dest => dest.EId, opt => opt.MapFrom(src => $"{src.UserId}"))

                .ReverseMap();
            CreateMap<CreateEmployeeDto, Employee>()
                        .ForMember(dest => dest.JobId, opt => opt.MapFrom(src => $"{src.JobId}"))

                .ReverseMap();

        }
    }
}