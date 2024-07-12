using System;
using System.Collections.Generic;

namespace Almacen_ASP.Models;

public partial class Compra
{
    public int IdCompra { get; set; }

    public int? IdProducto { get; set; }

    public int? IdUsuario { get; set; }

    public DateOnly? FechaCompra { get; set; }

    public decimal? Cantidad { get; set; }

    public virtual Producto? IdProductoNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
