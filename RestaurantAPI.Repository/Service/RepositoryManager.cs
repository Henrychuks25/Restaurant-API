using AutoMapper;
using RestaurantAPI.Entities.Contexts;
using RestaurantAPI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Repository.Service
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly Contexts _contexts;
        private readonly IMapper _mapper;
        private readonly Lazy<IBookingRepo> _bookingRepo;
        private readonly Lazy<IMenuTableRepo> _menuTableRepo;
        private readonly Lazy<IOrderRepo> _orderRepo;
        private readonly Lazy<IFoodRepo> _foodRepo;
        private readonly Lazy<IEmployeeListRepo> _employeeListRepo;
        private readonly Lazy<IEmployeeRepo> _employeeRepo;
        private readonly Lazy<ICustomerRepo> _customerRepo;
        private readonly Lazy<IItemRepo> _itemRepo;

        public RepositoryManager(Contexts contexts, IMapper mapper)
        {
            _contexts = contexts;
            _mapper = mapper;
            _bookingRepo = new Lazy<IBookingRepo>(() => new BookingService(contexts));
            _menuTableRepo = new Lazy<IMenuTableRepo>(() => new MenuTableService(contexts));
            _orderRepo = new Lazy<IOrderRepo>(() => new OrderService(contexts));
            _foodRepo = new Lazy<IFoodRepo>(() => new FoodService(contexts, mapper));
            _employeeListRepo = new Lazy<IEmployeeListRepo>(() => new EmployeeListService(contexts));
            _employeeRepo = new Lazy<IEmployeeRepo>(() => new EmployeeService(contexts, mapper));
            _customerRepo = new Lazy<ICustomerRepo>(() => new CustomerService(contexts));
            _itemRepo = new Lazy<IItemRepo>(() => new ItemService(contexts, mapper));
        }
        public IMenuTableRepo Menu => _menuTableRepo.Value;
        public IOrderRepo Order => _orderRepo.Value;
        public IFoodRepo Food => _foodRepo.Value;
        public IEmployeeListRepo EmpList => _employeeListRepo.Value;
        public IEmployeeRepo Employee => _employeeRepo.Value;
        public IBookingRepo Booking => _bookingRepo.Value;
        public ICustomerRepo Customer => _customerRepo.Value;
        public IItemRepo Item => _itemRepo.Value;

        public async Task SaveAsync() => await _contexts.SaveChangesAsync();
        //public Task SaveAsync()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
