using Application.Repositories.Abstract;
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


        
    }
}
