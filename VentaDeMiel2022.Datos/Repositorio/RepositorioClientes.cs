using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Datos.Repositorio
{
    public class RepositorioClientes: IRepositorioCliente
    {
        private readonly VentaDeMiel2022DbContext context;

        public RepositorioClientes()
        {
            context = new VentaDeMiel2022DbContext();
        }
        public void Guardar(Cliente cliente)
        {
            try
            {
                if (cliente.TipoDeDocumento != null  && cliente.NombreLocalidad != null && cliente.NombreProvincia != null
                && cliente.NombrePais != null)
                {
                    context.TipoDeDocumentos.Attach(cliente.TipoDeDocumento);
                    context.Localidades.Attach(cliente.NombreLocalidad);
                    context.Provincias.Attach(cliente.NombreProvincia);
                    context.Paises.Attach(cliente.NombrePais);

                }
                if (cliente.ClienteId == 0)
                {
                    context.Clientes.Add(cliente);
                }
                else
                {
                    var ClientesInDb = context.Clientes.SingleOrDefault(p => p.ClienteId == cliente.ClienteId);
                    if (ClientesInDb == null)
                    {
                        throw new Exception("Código de Cliente inexistente");
                    }

                    ClientesInDb.Nombre = cliente.Nombre;
                    ClientesInDb.TipoDeDocumentoId = cliente.TipoDeDocumentoId;
                    ClientesInDb.LocalidadId = cliente.LocalidadId;
                    ClientesInDb.ProvinciaId = cliente.ProvinciaId; 
                    ClientesInDb.PaisId = cliente.PaisId;

                    context.Entry(ClientesInDb).State = EntityState.Modified;

                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Cliente> GetLista(TipoDeDocumento td = null, Localidad L= null, Provincia pr= null, Pais p=null)
        {
            try
            {


                return context.Clientes.Include(p => p.TipoDeDocumento)
                    .Include(p => p.NombreLocalidad)
                    .Include(p => p.NombreProvincia)
                    .Include(p => p.NombrePais)
                    .AsNoTracking().ToList();
                //return context.Clientes.Include(p => p.NombreLocalidad).AsNoTracking().ToList()
                //        .Include(p => p.NombreProvincia).AsNoTracking().ToList()
                //        .Include(p => p.NombrePais).AsNoTracking().ToList();

                //return lista;
                //    var query = context.Clientes.Include(td.Descripcion).AsNoTracking().ToList();
                //    var localidadDbQuery = context.Clientes.Include(L.NombreLocalidad).AsNoTracking().ToList();
                //    var provinciaDbQuery = context.Clientes.Include(pr.NombreProvincia).AsNoTracking().ToList();
                //    var paisDbQuery = context.Clientes.Include(p.NombrePais).AsNoTracking().ToList();


                //if (td != null && L != null && pr != null && p != null)
                //{
                //    query = (DbQuery<Cliente>)query.Where(d => d.TipoDeDocumentoId == d.TipoDeDocumentoId);
                //    localidadDbQuery = (DbQuery<Cliente>)localidadDbQuery.Where(d => d.LocalidadId == d.LocalidadId);
                //    provinciaDbQuery = (DbQuery<Cliente>) provinciaDbQuery.Where(d => d.ProvinciaId == d.ProvinciaId);
                //    paisDbQuery = (DbQuery<Cliente>) paisDbQuery.Where(d => d.PaisId == d.PaisId);
                //}

                //switch (orden)
                //{
                //    case Orden.BD:
                //        break;
                //    case Orden.AZ:
                //        query = (DbQuery<Cliente>) query.OrderBy(p => p.Nombre);
                //        break;
                //    case Orden.ZA:
                //        query = (DbQuery<Cliente>) query.OrderByDescending(p => p.Nombre);
                //        break;

                //    default:
                //        throw new ArgumentOutOfRangeException(nameof(orden), orden, null);
                //}
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //public Cliente d;
        //public TipoDeDocumento td;
        //public Localidad L;
        //public Provincia pr;
        //public Pais p;
        //public Orden orden;
        
        //public List<Cliente> GetLista()
        //{

        //    try
        //    {
               
                
        //         return context.Clientes.Include(p => p.TipoDeDocumento).Include(p => p.NombreLocalidad).Include(p => p.NombreProvincia).Include(p => p.NombrePais).AsNoTracking().ToList();
        //        //return context.Clientes.Include(p => p.NombreLocalidad).AsNoTracking().ToList()
        //        //        .Include(p => p.NombreProvincia).AsNoTracking().ToList()
        //        //        .Include(p => p.NombrePais).AsNoTracking().ToList();

        //         //return lista;
        //         //    var query = context.Clientes.Include(td.Descripcion).AsNoTracking().ToList();
        //         //    var localidadDbQuery = context.Clientes.Include(L.NombreLocalidad).AsNoTracking().ToList();
        //         //    var provinciaDbQuery = context.Clientes.Include(pr.NombreProvincia).AsNoTracking().ToList();
        //         //    var paisDbQuery = context.Clientes.Include(p.NombrePais).AsNoTracking().ToList();


        //         //if (td != null && L != null && pr != null && p != null)
        //         //{
        //         //    query = (DbQuery<Cliente>)query.Where(d => d.TipoDeDocumentoId == d.TipoDeDocumentoId);
        //         //    localidadDbQuery = (DbQuery<Cliente>)localidadDbQuery.Where(d => d.LocalidadId == d.LocalidadId);
        //         //    provinciaDbQuery = (DbQuery<Cliente>) provinciaDbQuery.Where(d => d.ProvinciaId == d.ProvinciaId);
        //         //    paisDbQuery = (DbQuery<Cliente>) paisDbQuery.Where(d => d.PaisId == d.PaisId);
        //         //}

        //         //switch (orden)
        //         //{
        //         //    case Orden.BD:
        //         //        break;
        //         //    case Orden.AZ:
        //         //        query = (DbQuery<Cliente>) query.OrderBy(p => p.Nombre);
        //         //        break;
        //         //    case Orden.ZA:
        //         //        query = (DbQuery<Cliente>) query.OrderByDescending(p => p.Nombre);
        //         //        break;

        //         //    default:
        //         //        throw new ArgumentOutOfRangeException(nameof(orden), orden, null);
        //         //}
        //    }
        //    catch (Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}

        public void Borrar(int clienteId)
        {
            try
            {
                var ClienteInDb = context.Clientes.SingleOrDefault(p => p.ClienteId == clienteId);
                if (ClienteInDb == null)
                {
                    throw new Exception("Código de cliente inexistente");
                }

                context.Entry(ClienteInDb).State = EntityState.Deleted;
                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Cliente GetClientePorId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Cliente cliente)
        {
            try
            {
                if (cliente.ClienteId == 0)
                {
                    return context.Clientes
                        .Any(p => p.NroDocumento == cliente.NroDocumento);
                }
                return context.Clientes.Any(p => p.Nombre == cliente.Nombre &&
                                                    p.ClienteId != cliente.ClienteId &&
                                                    p.Apellido != cliente.Apellido);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Cliente cliente)
        {
            try
            {
                return context.DetalleVentas
                    .Any(dt => dt.ClienteId == cliente.ClienteId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
