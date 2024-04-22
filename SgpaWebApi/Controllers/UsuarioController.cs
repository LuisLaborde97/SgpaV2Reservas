using AccesoDatos.Models;
using AccesoDatos.Operaciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SgpaWebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {   
        private UsuarioDAO UsuarioDAO = new UsuarioDAO();
        [HttpPost("Authentication")]
        public string login([FromBody] Usuario user)
        {
            var users = UsuarioDAO.login(user.Usuario1, user.Password);

            if (users != null)
            {
                return users;
            }
            else
            {
                return null;
            }
        }
    }
}
