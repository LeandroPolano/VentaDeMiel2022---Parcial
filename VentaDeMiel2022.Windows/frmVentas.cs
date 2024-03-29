﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicios.Servicios.Facades;
using VentaDeMiel2022.Windows.Clases;
using VentaDeMiel2022.Windows.Helpers;
using VentaDeMiel2022.Windows.Ninject;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Servicios.Servicios.Facades;
using VentaDeMiel2022.Windows.Helpers;
using VentaDeMiel2022.Windows.Ninject;
using VentaDeMiel2022.Windows;
using CoffeeShop2022.Windows;
using VentaDeMiel2022.Servicio.Servicios.Facades;

namespace VentaDeMiel2022.Windows
{
    public partial class frmVentas : Form
    {
        public frmVentas(IServicioVentas servicio)
        {
            InitializeComponent();
            this.servicio = servicio;
            DatosDataGridView.ClearSelection();
            DatosDataGridView.Refresh();

        }

        private IServicioVentas servicio;
        private List<Venta> lista;
        private IServicioEnvases servicioEnvases;
        private IServicioClientes servicioClientes;
        private IServicioVendedor servicioVendedor;

        private void CerrarIconButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NuevoIconButton_Click(object sender, EventArgs e)
        {
            frmVentasAE frm = new frmVentasAE(DI.Create<IServicioEnvases>(), DI.Create<IServicioClientes>(), DI.Create<IServicioVendedor>()) { Text = "Nueva Venta" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }

            try
            {

                Venta venta = frm.GetVenta();
                servicio.Guardar(venta);
                var r = HelperGrid.ConstruirFila(DatosDataGridView);
                HelperGrid.SetearFila(r, venta);
                HelperGrid.AgregarFila(DatosDataGridView, r);
                HelperMensaje.Mensaje(TipoMensaje.OK, "Venta Registrada", "Mensaje");

            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
            DatosDataGridView.ClearSelection(); 
            DatosDataGridView.Refresh();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {

            //try
            //{
            //    lista = servicio.GetVentas();

            //    // Verificar si la lista no es null antes de mostrar los datos en la grilla
            //    if (lista != null)
            //    {
            //        // Verificar si DatosDataGridView no es null antes de intentar mostrar los datos
            //        if (DatosDataGridView != null)
            //        {
            //            HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            //        }
            //        else
            //        {
            //            throw new Exception("La referencia a DatosDataGridView es null.");
            //        }
            //    }
            //    else
            //    {
            //        // Tratar el caso en el que la lista sea null
            //        throw new Exception("La lista de ventas es null.");
            //    }
            //}
            //catch (Exception exception)
            //{
            //    HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            //}
            //servicio=new ServicioVentas();
            try
            {
                //HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
                lista = servicio.GetVentas();
                HelperForm.MostrarDatosEnGrilla(DatosDataGridView, lista);
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
            DatosDataGridView.ClearSelection();

        }

        private void AnularIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            var venta = (Venta)r.Tag;
            if (venta.Estado == EstadoVenta.Anulada || venta.Estado == EstadoVenta.Pagada)
            {
                return;
            }

            try
            {
                venta.Estado = EstadoVenta.Anulada;
                servicio.CambiarEstado(venta);
                HelperGrid.SetearFila(r, venta);
                HelperMensaje.Mensaje(TipoMensaje.OK, "Venta anulada!!!", "Mensaje");
                
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
            
        }

        private void DetalleIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            var venta = (Venta)r.Tag;
            try
            {
                venta.DetalleVentas = servicio.GetDetalleVenta(venta.VentaId);
                frmDetalleVenta frm = new frmDetalleVenta() { Text = "Detalle de la Venta" };
                frm.SetVenta(venta);
                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, ex.Message, "Error");
            }
            DatosDataGridView.ClearSelection();
            DatosDataGridView.Refresh();
        }

        private void CobrarIconButton_Click(object sender, EventArgs e)
        {
            if (DatosDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            var r = DatosDataGridView.SelectedRows[0];
            var venta = (Venta)r.Tag;

            if (venta.Estado != EstadoVenta.Proceso)
            {
                MessageBox.Show("No se puede cobrar una venta que no está en estado de proceso.", "Estado de Venta Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            frmCobro frm = new frmCobro() { Text = "Seleccionar método de cobro" };
            frm.SetMonto(venta.Total);
            DialogResult dr = frm.ShowDialog(this);

            try
            {
                venta.Estado = EstadoVenta.Pagada;
                servicio.CambiarEstado(venta);
                HelperGrid.SetearFila(r, venta);
                HelperMensaje.Mensaje(TipoMensaje.OK, "Venta Pagada!!!", "Mensaje");
            }
            catch (Exception exception)
            {
                HelperMensaje.Mensaje(TipoMensaje.Error, exception.Message, "Error");
            }
            DatosDataGridView.ClearSelection();
            DatosDataGridView.Refresh();
        }

    }


}

