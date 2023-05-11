using Microsoft.AspNetCore.Mvc;
using System.Drawing;
using HMO.Common;
using HMO.Common.DTO;
using HMO.Services.Interfaces;
using Microsoft.AspNetCore.Hosting.Server;
using System.IO;
using System.Net.Http.Headers;


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
            if (id != null)
            {
              
                return new FileContentResult(System.IO.File.ReadAllBytes("./Images/" + id+".jpg"), "jpg");
            }
            return null;
        }
        // the HTTP post request. The Body size limit is disabled 
        [HttpPost, DisableRequestSizeLimit]
        [HttpPost("{id}")]
        public IActionResult UploadFile(string id)
        {
            try
            {
                // 1. get the file form the request
                var postedFile = Request.Form.Files[0];
                // 2. set the file uploaded folder
                var uploadFolder = Path.Combine(Directory.GetCurrentDirectory(), "Images");
                // 3. check for the file length, if it is more than 0 the save it
                if (postedFile.Length > 0)
                {
                    // 3a. read the file name of the received file
                    var fileName = id +".jpg";
                    // 3b. save the file on Path
                    var finalPath = Path.Combine(uploadFolder, fileName);
                    using (var fileStream = new FileStream(finalPath, FileMode.Create))
                    {
                        postedFile.CopyTo(fileStream);
                    }
                    return Ok($"File is uploaded Successfully");
                }
                else
                {
                    return BadRequest("The File is not received.");
                }


            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Some Error Occcured while uploading File {ex.Message}");
            }
        }


    }
}
