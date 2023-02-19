using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Entities.Contexts;
using RestaurantAPI.Entities.Models;
using RestaurantAPI.Profiles.Dto;
using RestaurantAPI.Repository.Interface;

namespace RestaurantAPI.Repository.Service
{
    public class FoodService : RepositoryBase<Food>, IFoodRepo
    {
        private readonly Contexts _contexts;
        private readonly IMapper _mapper;

        public FoodService(Contexts contexts, IMapper mapper)
            : base(contexts)
        {
            _contexts = contexts;
            _mapper = mapper;
        }

        public async Task Create(CreateFoodDto food)
        {
            if(food == null)
            {
                throw new ArgumentNullException();
            }
           var mappedFood =   _mapper.Map<Food>(food);
            _contexts.Foods.Add(mappedFood);
          await _contexts.SaveChangesAsync();
        }

        public async void Delete(FoodDto food)
        {
            //var foodExist = await  GetFoodAsync(food.FId, true);
            //if(foodExist == null)
            // {
            //     throw new ArgumentNullException();
            // }
            // _contexts.Foods.Remove(food.FId);
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<FoodDto>> GetAllFoodAsync(bool trackChanges)
        {
           var result = await FindAll(trackChanges).OrderBy(f=>f.FName).ToListAsync();
            if(result.Count == 0)
            {
                return Enumerable.Empty<FoodDto>();
            }
            var fResult = _mapper.Map<IEnumerable<FoodDto>>(result); 
            return fResult;
        }

        public async Task<FoodDto> GetFoodAsync(Guid foodId, bool trackChanges)
        {
            var result = await FindByCondition(f => f.FId.Equals(foodId), trackChanges).OrderBy(f => f.FName).FirstOrDefaultAsync();
            if(result == null)
            {
                throw new ArgumentNullException();
            }
            var fResult = _mapper.Map<FoodDto>(result);
            return fResult;
        }

        public async Task<FoodDto> GetFoodByNameAsync(string name, bool trackChanges)
        {
            var result = await FindByCondition(f => f.FName.Equals(name), trackChanges).OrderBy(f => f.FName).FirstOrDefaultAsync();
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            var fResult = _mapper.Map<FoodDto>(result);
            return fResult;
        }

        public async Task Update(UpdateFoodDto food)
        {
          var chkFoodExist =  await GetFoodAsync(food.FId, true);
            if (chkFoodExist != null)
            {
              await  Update(food);
            }

            throw new NotImplementedException();
        }
    }
   
}