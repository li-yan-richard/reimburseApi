using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReimburseController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ReimburseController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost]
        public JsonResult Post()
        {
            try
            {
                Console.WriteLine("Amount: "+Request.Form["PurchaseAmount"]);
                Console.WriteLine("Date: "+Request.Form["PurchaseDate"]);
                Console.WriteLine("Desc: "+Request.Form["PurchaseDesc"]);
                var file = Request.Form.Files[0];
                Console.WriteLine("FileName: "+ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"'));
                Console.WriteLine("File Size: "+ContentDispositionHeaderValue.Parse(file.ContentDisposition).Size);

                return new JsonResult("Backend received Successfully");
                //the following code will save file to disk.
                /*
                var pathToSave = "C:\\temp";
                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return new JsonResult("Committed Successfully");
                }
                else
                {
                    return new JsonResult("No file");
                }
                */
            }
            catch (Exception ex)
            {
                return new JsonResult(ex.Message);
            }
        }
    }
}
