
using RestaurantAPI.Profiles.Dto;

public interface IEmployeeRepo{

    Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync(bool trackChanges);
    Task<EmployeeDto> GetEmployeeAsync(Guid employeeId, bool trackChanges);
    Task<EmployeeDto> GetFoodByNameAsync(string name, bool trackChanges);
    Task Create(CreateEmployeeDto employee);

    Task Update(UpdateEmployeeDto employee);


    void Delete(EmployeeDto employee);
}