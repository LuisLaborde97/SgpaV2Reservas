using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public int IdRecurso { get; set; }

    public int IdUsuario { get; set; }

    public int Estado { get; set; }

    public string Fecha { get; set; } = null!;
}
