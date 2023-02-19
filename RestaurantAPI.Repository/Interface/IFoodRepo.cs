using RestaurantAPI.Profiles.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI.Repository.Interface
{
    public interface IFoodRepo
    {
        Task<IEnumerable<FoodDto>> GetAllFoodAsync(bool trackChanges);
        Task<FoodDto> GetFoodAsync(Guid foodId, bool trackChanges);
        Task<FoodDto> GetFoodByNameAsync(string name, bool trackChanges);
        void Create(CreateFoodDto food);

        Task Update(UpdateFoodDto food);


        void Delete(FoodDto user);
    }
}
