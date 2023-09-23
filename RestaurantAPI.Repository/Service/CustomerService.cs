using RestaurantAPI.Entities.ModelContexts;
using RestaurantAPI.Entities.Models;

namespace RestaurantAPI.Repository.Service
{
    public class CustomerService : RepositoryBase<Customer>, ICustomerRepo
    {

        public CustomerService(Contexts contexts)
            : base(contexts)
        {

        }
    }
    
}