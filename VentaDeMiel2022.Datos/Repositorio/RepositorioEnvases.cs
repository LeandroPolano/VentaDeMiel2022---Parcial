using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VentaDeMiel2022.Datos.Repositorios.Facades;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;

namespace VentaDeMiel2022.Datos.Repositorios
{
    public class RepositorioEnvases : IRepositorioEnvases
    {
        private readonly VentaDeMiel2022DbContext context;

        public RepositorioEnvases(VentaDeMiel2022DbContext context)
        {
            this.context = context;
        }

        public void Guardar(Envase envase)
        {
            try
            {
                if (envase.EnvaseId == 0)
                {
                    context.Envases.Add(envase);
                }
                else
                {
                    var envaseInDb = context.Envases.SingleOrDefault(e => e.EnvaseId == envase.EnvaseId);
                    if (envaseInDb == null)
                    {
                        throw new Exception("Código de envase inexistente...");
                    }

                    envaseInDb.Descripcion = envase.Descripcion;
                    envaseInDb.TipoEnvaseId = envase.TipoEnvaseId;
                    envaseInDb.Precio = envase.Precio;
                    envaseInDb.Stock = envase.Stock;
                    if (envase.Imagen != null)
                    {
                        envaseInDb.Imagen = envase.Imagen;
                    }
                    context.Entry(envaseInDb).State = EntityState.Modified;
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Envase> GetLista(TipoEnvase tp = null, Orden orden = Orden.BD)
        {
            try
            {
                var query = context.Envases.Include(e => e.TipoEnvase);
                if (tp != null)
                {
                    query = query.Where(e => e.TipoEnvaseId == tp.TipoEnvaseId);
                }

                switch (orden)
                {
                    case Orden.BD:
                        break;
                    case Orden.AZ:
                        query = query.OrderBy(e => e.Descripcion);
                        break;
                    case Orden.ZA:
                        query = query.OrderByDescending(e => e.Descripcion);
                        break;
                    case Orden.ASC:
                        query = query.OrderBy(e => e.Precio);
                        break;
                    case Orden.DESC:
                        query = query.OrderByDescending(e => e.Precio);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(orden), orden, null);
                }
                return query.AsNoTracking().ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Borrar(int envaseId)
        {
            try
            {
                var envaseInDb = context.Envases.SingleOrDefault(e => e.EnvaseId == envaseId);
                if (envaseInDb == null)
                {
                    throw new Exception("Código de envase inexistente");
                }

                context.Entry(envaseInDb).State = EntityState.Deleted;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Envase GetEnvasePorId(int id)
        {
            try
            {
                return context.Envases.SingleOrDefault(e => e.EnvaseId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Envase envase)
        {
            try
            {
                return context.DetalleVentas.Any(dt => dt.EnvaseId == envase.EnvaseId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Envase envase)
        {
            try
            {
                if (envase.EnvaseId == 0)
                {
                    return context.Envases.Any(e => e.Descripcion == envase.Descripcion);
                }
                return context.Envases.Any(e => e.Descripcion == envase.Descripcion &&
                                                   e.EnvaseId != envase.EnvaseId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
