using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Entities.Contexts;
using RestaurantAPI.Entities.Models;
using RestaurantAPI.Profiles.Dto;
using RestaurantAPI.Repository.Interface;

namespace RestaurantAPI.Repository.Service
{
    public class JobService : RepositoryBase<Job>, IJobRepo
    {
        private readonly IMapper _mapper;
        private readonly Contexts _contexts;

        public JobService(Contexts contexts, IMapper mapper)
            : base(contexts)
        {
            _contexts = contexts;
            _mapper = mapper;
        }

        public async Task Create(CreateJobDto job)
        {
            if (job == null)
            {
                throw new ArgumentNullException();
            }
            var mappedJobs = _mapper.Map<Job>(job);
            _contexts.Jobs.Add(mappedJobs);
            await _contexts.SaveChangesAsync();
        }

        public void Delete(JobDto job)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<JobDto>> GetAllJobsAsync(bool trackChanges)
        {
            var result = await FindAll(trackChanges).OrderBy(f => f.Title).ToListAsync();
            if (result.Count == 0)
            {
                return Enumerable.Empty<JobDto>();
            }
            var fResult = _mapper.Map<IEnumerable<JobDto>>(result);
            return fResult;
        }

        public async Task<JobDto> GetJobAsync(Guid jobId, bool trackChanges)
        {
            var result = await FindByCondition(f => f.Id.Equals(jobId), trackChanges).OrderBy(f => f.Title).FirstOrDefaultAsync();
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            var fResult = _mapper.Map<JobDto>(result);
            return fResult;
        }

        public async Task<JobDto> GetJobByNameAsync(string name, bool trackChanges)
        {
            var result = await FindByCondition(f => f.Title.Equals(name), trackChanges).OrderBy(f => f.Title).FirstOrDefaultAsync();
            if (result == null)
            {
                throw new ArgumentNullException();
            }
            var fResult = _mapper.Map<JobDto>(result);
            return fResult;
        }

        public Task Update(UpdateJobDto job)
        {
            throw new NotImplementedException();
        }
    }
 
}