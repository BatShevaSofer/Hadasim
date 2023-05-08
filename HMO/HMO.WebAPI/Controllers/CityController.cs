using HMO.Common.DTO;
using HMO.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private readonly ICityService _citytService;
        public CityController(ICityService CityService)
        {
            _citytService = CityService;
        }
        // GET: api/<CityController>
        [HttpGet]
        public Task<List<CityDTO>> Get()
        {
            return _citytService.GetAllAsync();
        }

        // GET api/<CityController>/5
        [HttpGet("{id}")]
        public Task<CityDTO> Get(int id)
        {
            return _citytService.GetByIdAsync(id);
        }

        // POST api/<CityController>
        [HttpPost]
        public Task<CityDTO> Post([FromBody] CityDTO cityDTO)
        {
            return _citytService.AddAsync(cityDTO);
        }

        // PUT api/<CityController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CityController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
