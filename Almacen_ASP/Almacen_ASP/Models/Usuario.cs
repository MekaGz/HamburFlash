using System;
using System.Collections.Generic;

namespace Almacen_ASP.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Nombre { get; set; }

    public string? Rol { get; set; }

    public string? Contraseña { get; set; }

    public string? Correo { get; set; }

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
