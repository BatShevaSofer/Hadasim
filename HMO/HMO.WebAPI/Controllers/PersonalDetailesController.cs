using HMO.Common.DTO;
using HMO.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalDetailesController : ControllerBase
    {
        private readonly IPersonalDetailesService _personalDetailesService;
       
        public PersonalDetailesController(IPersonalDetailesService personalDetailesService)
        {
            _personalDetailesService = personalDetailesService;
            
        }

        // GET: api/<PersonalDetailesController>
        [HttpGet]
        public Task<List<PersonalDetailesDTO>> Get()
        {
            
            return _personalDetailesService.GetAllAsync();
        }

        // GET api/<PersonalDetailesController>/5
        [HttpGet("{id}")]
        public Task<PersonalDetailesDTO> Get(string id)
        {
            
            return _personalDetailesService.GetByIdAsync(id);
        }
        [Route("/Month")]
        [HttpGet]
        public Task<List<PersonalDetailesDTO>> GetByMonth()
        {
            return _personalDetailesService.GetByMonth();
           
            
        }




        // POST api/<PersonalDetailesController>
        [HttpPost]
        public Task<PersonalDetailesDTO> Post([FromBody] PersonalDetailesDTO personalDetailesDTO)
        { 

           
            return _personalDetailesService.AddAsync(personalDetailesDTO);

        }

        // PUT api/<PersonalDetailesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PersonalDetailesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
