using System;
using System.Collections.Generic;

namespace Almacen_ASP.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Nombre { get; set; }

    public DateOnly? FechaVencimiento { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Cantidad { get; set; }

    public int? IdProveedor { get; set; }

    public int? NivelMinimo { get; set; }

    public virtual ICollection<Alertum> Alerta { get; set; } = new List<Alertum>();

    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();

    public virtual Proveedor? IdProveedorNavigation { get; set; }
}
