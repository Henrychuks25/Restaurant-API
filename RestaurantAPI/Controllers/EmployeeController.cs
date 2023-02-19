using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Profiles.Dto;
using RestaurantAPI.Repository.Interface;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeRepo _employeeRepo;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeRepo employeeRepo)
        {
            _logger = logger;
            _employeeRepo = employeeRepo;
        }

        [HttpGet(Name = "GetAllEmployees")]
        public async Task<IEnumerable<EmployeeDto>> Get(bool trackAllChanges)
        {

          var result = await _employeeRepo.GetAllEmployeesAsync(trackAllChanges);
            if(result == null)
            {
                return (IEnumerable<EmployeeDto>)NotFound();
            }

            return result;
        }

        [HttpPost(Name = "CreateEmployee")]
        public async  Task<IActionResult> Post(CreateEmployeeDto createEmployee)
        {
            if (createEmployee == null)
            {
                return NotFound();
            }
            await _employeeRepo.Create(createEmployee);
        
            return Ok();
        }


    }
}