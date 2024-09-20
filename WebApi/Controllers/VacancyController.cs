using Application.Repositories.Abstract;
using Domain.DTOs;
using Domain.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VacancyController : ControllerBase
    {

        private readonly IVacancyRepository _repo;

        public VacancyController(IVacancyRepository repo)
        {
            _repo = repo;
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var vacancies = _repo.GetAllAsync().Result;
            return Ok(vacancies);
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> Get(long id)
        {
            var vacancy = await _repo.GetAsync(id);
            return Ok(vacancy);
        }



        [HttpPost("[action]")]
        public async Task<IActionResult> Add(VacancyAddDto dto)
        {
            var vacancy = new Vacancy()
            {
                Name = dto.Name,
                Description = dto.Description,
                Location = dto.Location,
                ImageLink = dto.ImageLink,
                MinSalary = dto.MinSalary,
                MaxSalary = dto.MaxSalary,
                VacantPlace = dto.VacantPlace,
                PublishedDate = DateTime.Now,
                JobNature = Domain.Enums.JobNature.FullTime,
                Experience = Domain.Enums.Experience.OneTwoYears,
                CreatedDate = DateTime.Now,
                UpdatedDate = null
            };

            await _repo.AddAsync(vacancy);
            return Ok(vacancy);
        }


        [HttpPut("[action]")]
        public async Task<IActionResult> Update(VacancyAddDto dto)
        {
            var vacancy = _repo.GetAsync(dto.Id).Result;

            vacancy.Name = dto.Name;
            vacancy.Description = dto.Description;
            vacancy.Location = dto.Location;
            vacancy.ImageLink = dto.ImageLink;
            vacancy.MinSalary = dto.MinSalary;
            vacancy.MaxSalary = dto.MaxSalary;
            vacancy.VacantPlace = dto.VacantPlace;
            vacancy.UpdatedDate = DateTime.Now;

            await _repo.UpdateAsync(vacancy);

            return Ok(vacancy);
        }
        
    }
}
