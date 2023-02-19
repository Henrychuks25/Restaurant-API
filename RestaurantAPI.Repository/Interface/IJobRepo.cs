using RestaurantAPI.Profiles.Dto;

public interface IJobRepo{
    Task<IEnumerable<JobDto>> GetAllJobsAsync(bool trackChanges);
    Task<JobDto> GetJobAsync(Guid jobId, bool trackChanges);
    Task<JobDto> GetJobByNameAsync(string name, bool trackChanges);
    Task Create(CreateJobDto job);

    Task Update(UpdateJobDto job);


    void Delete(JobDto job);
}