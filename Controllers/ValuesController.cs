using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using response_api.Models;

namespace response_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeController : ControllerBase
    {
        // POST api/codes
        [HttpPost]
        public ActionResult Post([FromBody] RequestedResponse codes)
        {
            return StatusCode(codes.ExpectedReturnedCode);
        }
    }
}
