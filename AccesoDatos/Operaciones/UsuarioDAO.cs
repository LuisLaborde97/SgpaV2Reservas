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

        public string login(string username, string password)
        {
            var user = context.Usuarios.Where(u => u.Usuario1.Equals(username) && u.Password.Equals(password)).FirstOrDefault();
            if (user != null)
            {
                return user.Usuario1;
            }
            else
            {
                return null;
            }
            
        }
    }
}
