using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Servicio.Servicios.Facades;
using VentaDeMiel2022.Windows.Clases;
using VentaDeMiel2022.Windows.UserControls;

namespace VentaDeMiel2022.Windows.Helpers
{
    public static class HelperGrid
    {
        public static void BorrarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Remove(r);
        }
        public static void AgregarFila(DataGridView dataGridView, DataGridViewRow r)
        {
            dataGridView.Rows.Add(r);
        }
        public static void LimpiarGrilla(DataGridView dataGridView)
        {
            dataGridView.Rows.Clear();
        }

        public static DataGridViewRow ConstruirFila(DataGridView dataGridView)
        {
            var r = new DataGridViewRow();
            r.CreateCells(dataGridView);
            return r;

        }
        
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Pais tp:
                    r.Cells[0].Value = ((Pais)obj).NombrePais;
                    break;
                case TipoEnvase te:
                    r.Cells[0].Value = ((TipoEnvase)obj).Descripcion;
                    break;
                case TipoDeDocumento td:
                    r.Cells[0].Value = ((TipoDeDocumento)obj).Descripcion;
                    break;
                case Provincia p:
                    r.Cells[0].Value = ((Provincia)obj).NombreProvincia;
                    r.Cells[1].Value = ((Provincia)obj).NombrePais.NombrePais;
                    break;
                case Localidad L:
                    r.Cells[0].Value = ((Localidad)obj).NombreLocalidad;
                    r.Cells[1].Value = ((Localidad)obj).NombreProvincia.NombreProvincia;
                    break;
                case Cliente CL :
                    r.Cells[0].Value = ((Cliente)obj).Nombre;
                    r.Cells[1].Value = ((Cliente)obj).Apellido;
                    r.Cells[2].Value = ((Cliente)obj).TipoDeDocumento.Descripcion;
                    r.Cells[3].Value = ((Cliente)obj).NroDocumento;
                    r.Cells[4].Value = ((Cliente)obj).Direccion;
                    r.Cells[5].Value = ((Cliente)obj).NombreLocalidad.NombreLocalidad;
                    r.Cells[6].Value = ((Cliente)obj).NombreProvincia.NombreProvincia;
                    r.Cells[7].Value = ((Cliente)obj).NombrePais.NombrePais;
                    r.Cells[8].Value = ((Cliente)obj).TelefonoFijo;
                    r.Cells[9].Value = ((Cliente)obj).TelefonoMovil;
                    r.Cells[10].Value =((Cliente)obj).CorreoElectronico;
                    break;
                case Vendedor V:
                    r.Cells[0].Value = ((Vendedor)obj).Nombre;
                    r.Cells[1].Value = ((Vendedor)obj).Apellido;
                    r.Cells[2].Value = ((Vendedor)obj).FechaNacimiento.ToShortDateString();
                    r.Cells[3].Value = ((Vendedor)obj).NroDocumento;
                    r.Cells[4].Value = ((Vendedor)obj).Direccion;
                    r.Cells[5].Value = ((Vendedor)obj).TelefonoFijo;
                    r.Cells[6].Value = ((Vendedor)obj).TelefonoMovil;
                    r.Cells[7].Value = ((Vendedor)obj).Correo;
                    
                    break;
                case Venta venta:
                    r.Cells[0].Value = venta.VentaId;
                    r.Cells[1].Value = venta.FechaVenta.ToShortDateString();
                    r.Cells[2].Value = venta.Total.ToString("C");
                    r.Cells[3].Value = venta.Estado.ToString();
                    break;
                case Envase envase:
                    r.Cells[0].Value = envase.Descripcion;
                    r.Cells[1].Value = envase.TipoEnvase.Descripcion;
                    r.Cells[2].Value = envase.Precio.ToString("C");
                    r.Cells[3].Value = envase.Stock;
                    break;
                case DetalleVenta dt:
                    r.Cells[0].Value = dt.Envase.Descripcion;
                    r.Cells[1].Value = dt.Cliente.Nombre;
                    r.Cells[2].Value = dt.Vendedor.Nombre;
                    r.Cells[3].Value = dt.PrecioVenta;
                    r.Cells[4].Value = dt.Cantidad;
                    r.Cells[5].Value = dt.Cantidad * dt.PrecioVenta;
                    break;
                case ItemCarrito carrito:
                    r.Cells[0].Value = carrito.Descripcion;
                    r.Cells[1].Value = carrito.Precio.ToString("C");
                    r.Cells[2].Value = carrito.Cantidad;
                    r.Cells[3].Value = carrito.SubTotal;
                    break;
            }   

            r.Tag = obj;

        }
    }
}
