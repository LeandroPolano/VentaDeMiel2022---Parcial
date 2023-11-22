using VentaDeMiel2022.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeMiel2022.Entidades.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime FechaVenta { get; set; }
        public decimal Total { get; set; }
        public EstadoVenta Estado { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; } = new List<DetalleVenta>();

    }
}
