using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaDeMiel2022.Entidades.Entidades
{
    public class Envase : ICloneable
    {

        public int EnvaseId { get; set; }
        public string Descripcion { get; set; }
        public int TipoEnvaseId { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public byte[] Imagen { get; set; }
        public TipoEnvase TipoEnvase { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
