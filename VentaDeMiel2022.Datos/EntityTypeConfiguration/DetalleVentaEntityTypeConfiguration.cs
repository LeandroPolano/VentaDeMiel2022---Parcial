using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Datos.EntityTypeConfiguration
{
    internal class DetalleVentaEntityTypeConfiguration : EntityTypeConfiguration<DetalleVenta>
    {
        public DetalleVentaEntityTypeConfiguration()
        {
            ToTable("DetalleVentas");
            Property(d => d.PrecioVenta).HasColumnName("Precio");
        }
    }
}
