using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("ApiCorsPolicy")]
    public class RegisterController : BaseController
    {
        public bool Post([FromBody] Register user)
        {
            return true;
        }
    }

    public class Register
    {
        public string email { get; set; }
        public string senha { get; set; }
        public string confirmarSenha { get; set; }
        public string nome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string cpf { get; set; }
        public string celular { get; set; }
    }
}