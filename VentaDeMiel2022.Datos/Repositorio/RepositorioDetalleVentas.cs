using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Datos.Repositorios.Facades;  // Asegúrate de incluir el espacio de nombres correcto
using VentaDeMiel2022.Datos.Repositorio.Facade;

namespace VentaDeMiel2022.Datos.Repositorios
{
    public class RepositorioDetalleVentas : IRepositorioDetalleVentas
    {
        private readonly VentaDeMiel2022DbContext context;

        public RepositorioDetalleVentas(VentaDeMiel2022DbContext context)
        {
            this.context = context;
        }

        public void Guardar(DetalleVenta detalleVenta)
        {
            try
            {
                context.DetalleVentas.Add(detalleVenta);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<DetalleVenta> GetDetalleVenta(int ventaId)
        {
            try
            {
                return context.DetalleVentas
                    .Include(dt => dt.Envase)
                    .Include(dt => dt.Cliente)
                    .Include(dt => dt.Vendedor)
                    .Where(dt => dt.VentaId == ventaId)
                    .ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
