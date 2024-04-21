using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Models
{
    public class IndexReservas
    {
        public int Id { get; set; }

        public string? NombreUsuario { get; set; }

        public string? NombreEvento { get; set; }

        public string? Descripcion { get; set; }

        public string? Fecha { get; set; }

        public int? Precio { get; set; }



    }

    public class ReservaOne
    {
        public int IdReserva { get; set; }

        public string? NombreUsuario { get; set; }

        public string? NombreEvento { get; set; }

        public string? Descripcion { get; set; }

        public string? Fecha { get; set; }

        public int? Precio { get; set; }
    }
}
