using RestaurantAPI.Entities.ModelContexts;
using RestaurantAPI.Entities.Models;
using RestaurantAPI.Repository.Interface;

namespace RestaurantAPI.Repository.Service
{
    public class MenuTableService : RepositoryBase<MenuTable>, IMenuTableRepo
    {

        public MenuTableService(Contexts contexts)
            : base(contexts)
        {
           
        }
    }
}