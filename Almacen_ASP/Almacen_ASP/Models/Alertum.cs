using System;
using System.Collections.Generic;

namespace Almacen_ASP.Models;

public partial class Alertum
{
    public int IdAlerta { get; set; }

    public int? IdProducto { get; set; }

    public string? Mensaje { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }
}
