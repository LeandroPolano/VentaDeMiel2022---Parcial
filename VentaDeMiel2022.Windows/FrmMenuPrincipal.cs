﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VentaDeMiel2022.Servicio.Servicios.Facades;
using VentaDeMiel2022.Servicios.Servicios.Facades;
using VentaDeMiel2022.Windows.Ninject;

namespace VentaDeMiel2022.Windows
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            PanelUbicaciones.Visible = false;
            panelPersonas.Visible = false;
            PanelEnvasesGeneral.Visible = false;
        }

      
        private void HideSubMenu()
        {
            PanelUbicaciones.Visible = false;
            panelPersonas.Visible = false;
            PanelEnvasesGeneral.Visible = false;

        }


        private void EnvasesGeneralesButton_Click(object sender, EventArgs e)
        {
            if (PanelEnvasesGeneral.Visible == false)
            {
                PanelEnvasesGeneral.Visible = true;

            }
            else
            {
                PanelEnvasesGeneral.Visible = false;

            }
        }

        private void UbicacionesButton_Click(object sender, EventArgs e)
        {
            if (PanelUbicaciones.Visible == false )
            {
                PanelUbicaciones.Visible = true;
            }
            else
            {
                PanelUbicaciones.Visible = false;
            }



        }

        private void PersonasButton_Click(object sender, EventArgs e)
        {
            if (panelPersonas.Visible ==false)
            {
                panelPersonas.Visible = true;

            }
            else
            {
                panelPersonas.Visible = false;

            }
        }




        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void ClientesButton_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes() { /*Text = "Clientes"*/ };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void PaisButton_Click(object sender, EventArgs e)
        {
            FrmPais frm = new FrmPais() { /*Text = "Paises" */};
            DialogResult dr = frm.ShowDialog(this);
        }

        private void CerrarButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TipoEnvaseButton_Click(object sender, EventArgs e)
        {
            FrmTipoEnvase frm = new FrmTipoEnvase() { /*Text = "Envases"*/ };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void ProvinciaButton_Click(object sender, EventArgs e)
        {
            FrmProvincia frm = new FrmProvincia() {/* Text = "Provincias"*/ };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmTiposDeDocumentos frm = new FrmTiposDeDocumentos() {/* Text = "Tipo De Documento"*/ };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void LocalidadButton_Click(object sender, EventArgs e)
        {
            FrmLocalidades frm = new FrmLocalidades() { /*Text = "Localidades"*/ };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void ClienteButton_Click(object sender, EventArgs e)
        {
            FrmClientes frm = new FrmClientes() { /*Text = "Clientes"*/ };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void VendedorButton_Click(object sender, EventArgs e)
        {
            FrmVendedores frm = new FrmVendedores() { /*Text = "Clientes"*/ };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void VentasButton_Click(object sender, EventArgs e)
        {
            frmVentas frm = new frmVentas(DI.Create<IServicioVentas>()) { /*Text = "Ventas"*/ };
            DialogResult dr = frm.ShowDialog(this);
        }

        private void EnvaseButton_Click(object sender, EventArgs e)
        {
            FrmEnvases frm = new FrmEnvases(DI.Create<IServicioEnvases>()) { /*Text = "Envases"*/ };
            DialogResult dr = frm.ShowDialog(this);
        }

       
    }
}
