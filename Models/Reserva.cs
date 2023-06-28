using System;
using System.Collections.Generic;

namespace proyecto_DBP.Models;

public partial class Reserva
{
    public int IdReserva { get; set; }

    public string NombreCliente { get; set; } = null!;

    public string ApellidosCliente { get; set; } = null!;

    public DateTime? FechaReserva { get; set; }

    public TimeSpan? HoraReserva { get; set; }

    public int TamañoMesa { get; set; }

    public string CorreoCliente { get; set; } = null!;

    public string? TelefonoCliente { get; set; }
    public int IdHorario { get; set; }
}
