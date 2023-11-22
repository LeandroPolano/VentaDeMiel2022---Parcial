using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeMiel2022.Entidades.Entidades
{
    public class DetalleVenta:ICloneable

    {
    public int DetalleVentaId { get; set; }
    public int VentaId { get; set; }
    public int ClienteId { get; set; }
    public int EnvaseId { get; set; }
    public int VendedorId { get; set; }
    public int Cantidad { get; set; }
    public decimal PrecioVenta { get; set; }
    public Vendedor Vendedor { get; set; }
    public Cliente Cliente { get; set; }
    public Venta Venta { get; set; }
    public Envase Envase { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
    }
}
