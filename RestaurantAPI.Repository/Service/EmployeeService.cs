using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Entities.Contexts;
using RestaurantAPI.Entities.Models;
using RestaurantAPI.Profiles.Dto;
using RestaurantAPI.Repository.Interface;

namespace RestaurantAPI.Repository.Service
{
    public class EmployeeService : RepositoryBase<Employee>, IEmployeeRepo
    {
        private readonly IMapper _mapper;
        private readonly Contexts _contexts;

        public EmployeeService(Contexts contexts, IMapper mapper)
            : base(contexts)
        {
            _contexts = contexts;
            _mapper = mapper;
        }

        public async Task Create(CreateEmployeeDto employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException();
            }
            var mappedEmployee = _mapper.Map<Employee>(employee);
            _contexts.Employees.Add(mappedEmployee);
            await _contexts.SaveChangesAsync();
        }

        public void Delete(EmployeeDto employee)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync(bool trackChanges)
        {
            var result = await FindAll(trackChanges).OrderBy(f => f.EName).ToListAsync();
            if (result.Count == 0)
            {
                return Enumerable.Empty<EmployeeDto>();
            }
            var fResult = _mapper.Map<IEnumerable<EmployeeDto>>(result);
            return fResult;
        }

        public async Task<EmployeeDto> GetEmployeeAsync(Guid employeeId, bool trackChanges)
        {
            var result = await FindByCondition(f => f.EId.Equals(employeeId), trackChanges).OrderBy(f => f.EName).FirstOrDefaultAsync();
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            var fResult = _mapper.Map<EmployeeDto>(result);
            return fResult;
        }

        public async Task<EmployeeDto> GetFoodByNameAsync(string name, bool trackChanges)
        {
            var result = await FindByCondition(f => f.EName.Equals(name), trackChanges).OrderBy(f => f.EName).FirstOrDefaultAsync();
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            var fResult = _mapper.Map<EmployeeDto>(result);
            return fResult;
        }

        public Task Update(UpdateEmployeeDto employee)
        {
            throw new NotImplementedException();
        }
    }
 
}