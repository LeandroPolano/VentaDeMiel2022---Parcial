﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VentaDeMiel2022.Datos.Repositorio.Facade;
using VentaDeMiel2022.Datos;
using VentaDeMiel2022.Entidades.Entidades;
namespace VentaDeMiel2022.Datos.Repositorios
{
    public class RepositorioVentas:IRepositorioVentas
    {
        private readonly VentaDeMiel2022DbContext context;
      

        public RepositorioVentas(VentaDeMiel2022DbContext context)
        {
            this.context = context;
        }

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
                context.Ventas.Add(venta);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void AnularVenta(Venta venta)
        {
            try
            {
                var existingEntity = context.Ventas.Find(venta.VentaId);
                if (existingEntity != null)
                {
                    context.Entry(existingEntity).CurrentValues.SetValues(venta);
                    context.SaveChanges();
                }
                else
                {
                    throw new InvalidOperationException("La entidad no existe en la base de datos.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            //try
            //{
            //    context.Entry(venta).State = EntityState.Modified;
            //    //context.SaveChanges();
            //}
            //catch (Exception e)
            //{
            //    throw new Exception(e.Message);
            //}
        }
    }
}
