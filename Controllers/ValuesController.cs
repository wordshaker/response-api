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
            switch (value.ExpectedReturnedCode)
                 {
                     case 200:
                         return Ok(" Winner, winner, chicken dinner ");
                     case 404:
                         return NotFound(" Still haven't found what you're looking for ");
                    case 500:
                         return NotFound(" Internal Server Error ");
                     default:
                         return BadRequest(" You haven't provided a recognised ExpectedReturnedCode");
                 }
        }
    }
}
