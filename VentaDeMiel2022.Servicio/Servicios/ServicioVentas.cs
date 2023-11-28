using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using VentaDeMiel2022.Datos;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Datos.Repositorios.Facades;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Servicios.Servicios.Facades;

namespace VentaDeMiel2022.Servicios.Servicios
{
    public class ServicioVentas:IServicioVentas
    {
        private readonly VentaDeMiel2022DbContext context;
        private readonly IRepositorioVentas repoVentas;
        private readonly IRepositorioDetalleVentas repoDetalle;
        private readonly IUnitOfWork unitOfWork;

        public ServicioVentas(VentaDeMiel2022DbContext context, IRepositorioVentas repoVentas, IRepositorioDetalleVentas repoDetalle, IUnitOfWork unitOfWork)
        {
            this.context = context;
            this.repoVentas = repoVentas;
            this.repoDetalle = repoDetalle;
            this.unitOfWork = unitOfWork;
        }

        //public ServicioVentas()
        //{
        //    context=new CoffeShop2022DbContext();
        //    repoVentas=new RepositorioVentas(context);
        //    repoDetalle=new RepositorioDetalleVentas(context);
        //}
        public List<Venta> GetVentas()
        {
            try
            {
                return context.Ventas.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Guardar(Venta venta)
        {
            try
            {
                using (var scope=new TransactionScope(TransactionScopeOption.Required))
                {
                    Venta ventaAux = new Venta()
                    {
                        FechaVenta = venta.FechaVenta,
                        Estado = venta.Estado,
                        Total = venta.Total
                    };
                    repoVentas.Guardar(ventaAux);
                    context.SaveChanges();
                    venta.VentaId = ventaAux.VentaId;
                    //context.SaveChanges();
                    foreach (var item in venta.DetalleVentas)
                    {
                        item.VentaId = venta.VentaId;
                        repoDetalle.Guardar(item);

                    }

                    //context.SaveChanges();
                    context.SaveChanges();

                    scope.Complete();

                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void CambiarEstado(Venta venta)
        {
            try
            {
                repoVentas.AnularVenta(venta);
                unitOfWork.Save();
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

                return repoDetalle.GetDetalleVenta(ventaId);



            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
