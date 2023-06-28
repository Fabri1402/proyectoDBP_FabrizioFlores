using System;
using System.Collections.Generic;

namespace proyecto_DBP.Models;

public partial class Horario
{
    public int IdHorario { get; set; } 

    public DateTime Fecha { get; set; }

    public TimeSpan Hora { get; set; }

    public int Tamaño { get; set; }
}
