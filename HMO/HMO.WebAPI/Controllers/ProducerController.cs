using HMO.Common.DTO;
using HMO.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProducerController : ControllerBase
    {
        private readonly IProducerService _producerService;
        public ProducerController(IProducerService ProducerService)
        {
            _producerService = ProducerService;
        }
        // GET: api/<ProducerController>
        [HttpGet]
        public Task<List<ProducerDTO>> Get()
        {
            return _producerService.GetAllAsync();
        }

        // GET api/<ProducerController>/5
        [HttpGet("{id}")]
        public Task<ProducerDTO> Get(int id)
        {
            return _producerService.GetByIdAsync(id);
        }

        // POST api/<ProducerController>
        [HttpPost]
        public Task<ProducerDTO> Post([FromBody] ProducerDTO ProducerDTO)
        {
            return _producerService.AddAsync(ProducerDTO);
        }

        // PUT api/<ProducerController>/5
        [HttpPut("{id}")]

        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProducerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
