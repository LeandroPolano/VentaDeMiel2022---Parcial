using System;
using System.Collections.Generic;
using VentaDeMiel2022.Datos;
using VentaDeMiel2022.Datos.Repositorios;
using VentaDeMiel2022.Datos.Repositorios.Facades;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicios.Servicios.Facades;

namespace VentaDeMiel2022.Servicios.Servicios
{
    public class ServicioEnvases : IServicioEnvases
    {
        private readonly IRepositorioEnvases repositorio;
        private readonly IUnitOfWork unitOfWork;
        private readonly VentaDeMiel2022DbContext context;

        public ServicioEnvases(VentaDeMiel2022DbContext context, IUnitOfWork unitOfWork, IRepositorioEnvases repositorio)
        {
            this.context = context;
            this.unitOfWork = unitOfWork;
            this.repositorio = repositorio;
        }

        public void Guardar(Envase envase)
        {
            try
            {
                repositorio.Guardar(envase);
                unitOfWork.Save();
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
                repositorio.Borrar(envaseId);
                unitOfWork.Save();
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
                return repositorio.GetEnvasePorId(id);
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
                return repositorio.Existe(envase);
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
                return repositorio.EstaRelacionado(envase);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Envase> GetLista(TipoEnvase tp, Orden orden)
        {
            try
            {
                return repositorio.GetLista(tp, orden);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
