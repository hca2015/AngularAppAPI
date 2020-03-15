using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ApiCorsPolicy")]
    public class LoginController : BaseController
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