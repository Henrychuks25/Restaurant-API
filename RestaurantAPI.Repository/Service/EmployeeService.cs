using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Entities.ModelContexts;
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
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
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
            var result = await FindAll(trackChanges).Include(e=>e.MenuTables)
                .Include(e => e.Foods)
                .Include(e => e.Orders)
                .OrderBy(f => f.Name).ToListAsync();
            if (result.Count == 0)
            {
                return Enumerable.Empty<EmployeeDto>();
            }
            var fResult = _mapper.Map<IEnumerable<EmployeeDto>>(result);
            return fResult;
        }

        public async Task<EmployeeDto> GetEmployeeAsync(Guid employeeId, bool trackChanges)
        {
            var result = await FindByCondition(f => f.Id.Equals(employeeId), trackChanges).OrderBy(f => f.Name).FirstOrDefaultAsync();
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            var fResult = _mapper.Map<EmployeeDto>(result);
            return fResult;
        }

        public async Task<EmployeeDto> GetEmployeeByNameAsync(string name, bool trackChanges)
        {
            var result = await FindByCondition(f => f.Id.Equals(name), trackChanges).OrderBy(f => f.Name).FirstOrDefaultAsync();
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            var fResult = _mapper.Map<EmployeeDto>(result);
            return fResult;
        }

        public async Task<EmployeeDto> Update(UpdateEmployeeDto employee)
        {
            //update a registered user

         
               
                    EmployeeDto result = null;


                    var Result = await _contexts.Employees.FirstOrDefaultAsync(c => c.Id == employee.Id);



                    if (Result == null)
                    {

                        throw new ArgumentNullException(nameof(Result));
                    }
                    var val = _mapper.Map(employee, Result);
                    _contexts.Entry(val).State = EntityState.Modified;
                    _contexts.Employees.Update(val);
                    await _contexts.SaveChangesAsync();                    
                    result = _mapper.Map<EmployeeDto>(val);

                    return result;


              
            
        }
    }
 
}