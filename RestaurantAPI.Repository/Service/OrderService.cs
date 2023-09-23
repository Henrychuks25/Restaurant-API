using RestaurantAPI.Entities.ModelContexts;
using RestaurantAPI.Entities.Models;
using RestaurantAPI.Repository.Interface;

namespace RestaurantAPI.Repository.Service
{
    public class OrderService : RepositoryBase<Order>, IOrderRepo
    {
       

        public OrderService(Contexts contexts)
            :base(contexts)
        {
           
        }
    }
}