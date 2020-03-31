using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<object> Get()
        {
            var response =  "{\"name\": \"John\",  \"age\": \"23\",\"email\": \"john.doe@google.com\"}";
            var result = JsonConvert.DeserializeObject<object>(response);
            return result;
        }
    }
}