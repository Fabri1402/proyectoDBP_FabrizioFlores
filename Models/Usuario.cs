using System;
using System.Collections.Generic;

namespace proyecto_DBP.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string UsuNombre { get; set; } = null!;

    public string UsuClave { get; set; } = null!;
}
