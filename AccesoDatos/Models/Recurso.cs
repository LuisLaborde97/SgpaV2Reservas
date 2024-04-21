using System;
using System.Collections.Generic;

namespace AccesoDatos.Models;

public partial class Recurso
{
    public int IdRecurso { get; set; }

    public string Nombre { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int Precio { get; set; }

    public int Estado { get; set; }
}
