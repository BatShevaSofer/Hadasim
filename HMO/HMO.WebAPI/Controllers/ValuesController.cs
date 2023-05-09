using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using HMO.Common;
using HMO.Common.DTO;
using HMO.Services.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HMO.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IPersonalDetailesService _personalDetailesService;
        public ValuesController(IPersonalDetailesService personalDetailesService)
        {
            _personalDetailesService = personalDetailesService;
        }
        

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<FileResult> Get(string id)
        {
            var img = await _personalDetailesService.GetByIdAsync(id);
            if (img.imageUrl != null)
            {
                string contentType = "image/" + Path.GetExtension(img.imageUrl).ToLower().Replace(".", ""); ;
                return new FileContentResult(System.IO.File.ReadAllBytes(img.imageUrl), contentType);
            }
            return null;
        }

        
    }
}
