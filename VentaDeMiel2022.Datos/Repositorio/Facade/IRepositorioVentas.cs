using System.Collections.Generic;
using VentaDeMiel2022.Entidades.Entidades;
namespace VentaDeMiel2022.Datos.Repositorio.Facade
{
    public interface IRepositorioVentas
    {
        List<Venta> GetVentas();
        void Guardar(Venta venta);
        void AnularVenta(Venta venta);
    }
}