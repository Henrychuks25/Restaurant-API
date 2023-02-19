using Microsoft.AspNetCore.Mvc;
using RestaurantAPI.Profiles.Dto;
using RestaurantAPI.Repository.Interface;

namespace RestaurantAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JobController : ControllerBase
    {
        
        private readonly ILogger<JobController> _logger;
        private readonly IJobRepo _jobRepo;

        public JobController(ILogger<JobController> logger, IJobRepo jobRepo)
        {
            _logger = logger;
            _jobRepo = jobRepo;
        }

        [HttpGet(Name = "GetAllJobs")]
        public async Task<IEnumerable<JobDto>> Get(bool trackAllChanges)
        {

          var result = await _jobRepo.GetAllJobsAsync(trackAllChanges);
            if(result == null)
            {
                return (IEnumerable<JobDto>)NotFound();
            }

            return result;
        }

        [HttpPost(Name = "CreateJob")]
        public async  Task<IActionResult> Post(CreateJobDto createJob)
        {
            if (createJob == null)
            {
                return NotFound();
            }
            await _jobRepo.Create(createJob);
        
            return Ok();
        }


    }
}