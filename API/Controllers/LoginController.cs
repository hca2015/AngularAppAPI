using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ApiCorsPolicy")]
    public class LoginController : ControllerBase
    {
        public bool Post([FromBody] User user)
        {
            return true;
        }
    }

    public class User
    {
        public string usuario { get; set; }
        public string senha { get; set; }
    }
}