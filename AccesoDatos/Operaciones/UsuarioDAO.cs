using AccesoDatos.Context;
using AccesoDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Operaciones
{
    public class UsuarioDAO
    {
        public RecursosContext context = new RecursosContext();

        public Usuario login(string username, string password)
        {
            var user = context.Usuarios.Where(u => u.Usuario1 == username && u.Password == password).FirstOrDefault();

            return user;
        }
    }
}
