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
    public class ValuesController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] RequestedResponse value)
        {
            return StatusCode(value.ExpectedReturnedCode);
        }
    }
}
