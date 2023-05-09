using HMO.Common.DTO;
using HMO.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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

        // POST api/<PersonalDetailesController>
        [HttpPost]
        public Task<PersonalDetailesDTO> Post([FromBody] PersonalDetailesDTO personalDetailesDTO)
        {
            WebClient client = new WebClient();
            try
            {
                string fileName = Path.GetFileName(personalDetailesDTO.imageUrl);
                client.DownloadFile(personalDetailesDTO.imageUrl, "./Images/" + fileName);
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during the download.
                Console.WriteLine("Error saving image to folder: " + ex.Message);
            }
            finally
            {
                client.Dispose();
            }
        
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
