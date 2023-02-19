using AutoMapper;
using RestaurantAPI.Entities.Contexts;
using RestaurantAPI.Entities.Models;

namespace RestaurantAPI.Repository.Service
{
    public class ItemService : RepositoryBase<Item>, IItemRepo
    {
        private readonly IMapper _mapper;
        public ItemService(Contexts contexts, IMapper mapper)
            : base(contexts)
        {
            _mapper = mapper;
        }
    }
 
}