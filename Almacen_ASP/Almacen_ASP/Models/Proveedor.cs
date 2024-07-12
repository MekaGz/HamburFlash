using System;
using System.Collections.Generic;

namespace Almacen_ASP.Models;

public partial class Proveedor
{
    public int IdProveedor { get; set; }

    public string? Nombre { get; set; }

    public string? Contacto { get; set; }

    public string? HistorialCompras { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
