using System.Collections.Generic;
using VentaDeMiel2022.Entidades.Entidades;

namespace VentaDeMiel2022.Datos.Repositorios.Facades
{
    public interface IRepositorioDetalleVentas
    {
        void Guardar(DetalleVenta detalleVenta);
        List<DetalleVenta> GetDetalleVenta(int ventaId);
    }
}
