using AccesoDatos.Models;
using AccesoDatos.Operaciones;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SgpaWebApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private ReservaDAO reserva = new ReservaDAO();

        [HttpGet("index")]

        public List<IndexReservas> getReservas(string usuario)
        {
            return reserva.index(usuario);
        }

        [HttpGet("idReserva")]

        public List<ReservaOne> showReserva(int id_reserva)
        {
            return reserva.showReserva(id_reserva).ToList();
        }

        [HttpPut("update")]

        public bool putReserva([FromBody]Reserva reservas)
        {
            return reserva.editReserva(reservas.IdReserva, reservas.IdRecurso, reservas.IdUsuario, reservas.Estado, reservas.Fecha);
        }

        [HttpPost("create")]

        public bool insertarReservas([FromBody]Reserva reservas)
        {
            return reserva.insertarReserva(reservas.IdRecurso, reservas.IdUsuario, reservas.Estado, reservas.Fecha);
        }

        [HttpDelete("delete")]

        public bool deleteReserva(int id)
        {
            return reserva.deleteReserva(id);
        }


    }
}

