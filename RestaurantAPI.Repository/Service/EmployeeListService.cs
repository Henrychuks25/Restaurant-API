using RestaurantAPI.Entities.Contexts;
using RestaurantAPI.Entities.Models;
using RestaurantAPI.Repository.Interface;

namespace RestaurantAPI.Repository.Service
{
    public class EmployeeListService : RepositoryBase<EmpList>, IEmployeeListRepo
    {

        public EmployeeListService(Contexts contexts)
            : base(contexts)
        {

        }
    }
    
}