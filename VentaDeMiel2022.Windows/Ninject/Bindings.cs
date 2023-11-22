using VentaDeMiel2022.Datos;
using VentaDeMiel2022.Datos.Repositorio;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Servicios.Servicios;
using VentaDeMiel2022.Servicios.Servicios.Facades;
using Ninject.Modules;
using VentaDeMiel2022.Servicio.Servicios.Facades;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Datos.Repositorios;
using VentaDeMiel2022.Datos.Repositorios.Facades;

namespace VentaDeMiel2022.Windows.Ninject
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<VentaDeMiel2022DbContext>().ToSelf().InSingletonScope();
            Bind<IUnitOfWork>().To<UnitOfWork>();

            Bind<IRepositorioTipoEnvase>().To<RepositorioTipoEnvase>();
            Bind<IServicioTipoEnvase>().To<ServicioTipoEnvase>();

            Bind<IRepositorioEnvases>().To<RepositorioEnvases>();
            Bind<IServicioEnvases>().To<ServicioEnvases>();

            Bind<IRepositorioVentas>().To<RepositorioVentas>();
            Bind<IRepositorioDetalleVentas>().To<RepositorioDetalleVentas>();

            Bind<IServicioVentas>().To<ServicioVentas>();


        }
    }
}
