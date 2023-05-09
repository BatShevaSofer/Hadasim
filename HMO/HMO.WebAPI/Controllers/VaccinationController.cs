using HMO.Common.DTO;
using HMO.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaccinationController : ControllerBase
    {
        private readonly IVaccinationService _vaccinationService;
        public VaccinationController(IVaccinationService vaccinationService)
        {
            _vaccinationService = vaccinationService;
        }

        // GET: api/<VaccinationController>
        [HttpGet]
        public Task<List<VaccinationDTO>> Get()
        {
            return _vaccinationService.GetAllAsync();
        }

        // GET api/<VaccinationController>/5
        [HttpGet("{id}")]
        public Task<VaccinationDTO> Get(int id)
        {
            return _vaccinationService.GetByIdAsync(id);
        }

        // POST api/<VaccinationController>
        [HttpPost]
        public Task<VaccinationDTO> Post([FromBody]VaccinationDTO VaccinationDTO)
        {
            return _vaccinationService.AddAsync(VaccinationDTO);
        }

        // PUT api/<VaccinationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VaccinationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
