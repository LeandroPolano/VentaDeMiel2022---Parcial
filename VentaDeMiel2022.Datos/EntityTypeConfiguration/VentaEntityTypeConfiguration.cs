using System.Data.Entity.ModelConfiguration;
using VentaDeMiel2022.Entidades.Entidades;

namespace CoffeeShop2022.Datos.EntityTypeConfiguration
{
    public class VentaEntityTypeConfiguration:EntityTypeConfiguration<Venta>
    {
        public VentaEntityTypeConfiguration()
        {
            ToTable("Ventas");
            Property(v => v.Estado).HasColumnName("EstadoVenta");
        }
    }
}
