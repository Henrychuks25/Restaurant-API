using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Profiles.Dto;
using RestaurantAPI.Repository.Interface;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("api/foods")]
    public class FoodController : ControllerBase
    {
        
        private readonly ILogger<FoodController> _logger;
        private readonly IFoodRepo _foodRepo;

        public FoodController(ILogger<FoodController> logger, IFoodRepo foodRepo)
        {
            _logger = logger;
            _foodRepo = foodRepo;
        }

        [HttpGet("", Name = "GetAllFood")]
        public async Task<IActionResult> Get(bool trackAllChanges)
        {

          var result = await _foodRepo.GetAllFoodAsync(trackAllChanges);
            if(result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        [HttpGet("{id}", Name = "GetById")]
        public async Task<IActionResult> GetById(Guid id, bool trackAllChanges)
        {

            var result = await _foodRepo.GetFoodAsync(id, trackAllChanges);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
        [HttpPost(Name = "CreateFood")]
        public async  Task<IActionResult> Post(CreateFoodDto createFood)
        {
            if (createFood == null)
            {
                return NotFound();
            }
            await  _foodRepo.Create(createFood);
        
            return Ok();
        }


    }
}