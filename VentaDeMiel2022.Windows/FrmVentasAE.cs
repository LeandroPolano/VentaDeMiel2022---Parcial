using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VentaDeMiel2022.Datos.Repositorios.Facades;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicios.Servicios;
using VentaDeMiel2022.Servicios.Servicios.Facades;
using VentaDeMiel2022.Windows.Clases;
using VentaDeMiel2022.Windows.Helpers;
using VentaDeMiel2022.Windows.UserControls;
using VentaDeMiel2022.Entidades.Entidades;
using VentaDeMiel2022.Entidades.Enum;
using VentaDeMiel2022.Servicios.Servicios.Facades;
using VentaDeMiel2022.Windows.Clases;
using VentaDeMiel2022.Windows.Helpers;
using VentaDeMiel2022.Servicio.Servicios.Facades;
using VentaDeMiel2022.Servicio.Servicios;
using VentaDeMiel2022.Windows.Ninject;

namespace VentaDeMiel2022.Windows
{
    public partial class frmVentasAE : Form
    {

        public frmVentasAE(IServicioEnvases servicioEnvase, IServicioClientes servicioCliente, IServicioVendedor servicioVendedor)
        {
            InitializeComponent();
            this.servicioEnvase = servicioEnvase;
            this.servicioCliente = servicioCliente;
            this.servicioVendedor = servicioVendedor;
        }
       
        private void frmVentasAE_Load2()
        {
            var servicioClientes = DI.Create<IServicioClientes>();
            var listaClientes = servicioClientes.GetLista();

            var servicioVendedores = DI.Create<IServicioVendedor>();
            var listaVendedores = servicioVendedores.GetLista(Orden.DESC);

            var servicioTipoEnvase = DI.Create<IServicioTipoEnvase>();
            var listaTipoEnvase = servicioTipoEnvase.GetLista();


            HelperCombos.CargarDatosComboClientes(ref ClientesComboBox);
            HelperCombos.CargarDatosComboVendedores(ref VendedoresComboBox);
            HelperCombos.CargarDatosComboTipoEnvase(ref TipoEnvasesComboBox);

            listaEnvase = servicioEnvase.GetLista(null, Orden.BD);


            MostrarListaEnLayout();
        }

        private IServicioEnvases servicioEnvase;
        private IServicioClientes servicioCliente;
        private IServicioVendedor servicioVendedor;
       
        private void CargarComboCliente()
        {
            HelperCombos.CargarDatosComboClientes(ref ClientesComboBox);
        }
        private List<Envase> listaEnvase;
        private List<Cliente> listaCliente;
        private List<Vendedor> listaVendedor;


        private void frmVentasAE_Load(object sender, EventArgs e)
        {
            //var servicioClientes = DI.Create<IServicioClientes>();
            //var listaClientes = servicioClientes.GetLista();

            //var servicioVendedores = DI.Create<IServicioVendedor>();
            //var listaVendedores = servicioVendedores.GetLista(Orden.DESC);

            //var servicioTipoEnvase = DI.Create<IServicioTipoEnvase>();
            //var listaTipoEnvase = servicioTipoEnvase.GetLista();

            listaEnvase = servicioEnvase.GetLista(tipoEnvase, Orden.BD);
            //listaCliente = servicioCliente.GetLista();
            //listaVendedor = servicioVendedor.GetLista(Orden.BD);


            HelperCombos.CargarDatosComboClientes(ref ClientesComboBox);
            HelperCombos.CargarDatosComboVendedores(ref VendedoresComboBox);
            HelperCombos.CargarDatosComboTipoEnvase(ref TipoEnvasesComboBox);



            MostrarListaEnLayout();
        }

        private void MostrarListaEnLayout()
        {
            EnvaseFlowLayoutPanel.Controls.Clear();
            foreach (var envase in listaEnvase)
            {
                ucEnvase ucEnvase = new ucEnvase
                {
                    EnvaseId = envase.EnvaseId,
                    Descripcion = envase.Descripcion,
                    Precio = envase.Precio.ToString("C"),
                    Imagen = envase.Imagen,

                };
                ucEnvase.AgregarIconButton.Tag = ucEnvase.EnvaseId;
                ucEnvase.AgregarIconButton.Click += AgregarEnvase;
                EnvaseFlowLayoutPanel.Controls.Add(ucEnvase);

            }
        }

        private void AgregarEnvase(object sender, EventArgs e)
        {
            var envaseId = (int)((Button)sender).Tag;
            var envase = servicioEnvase.GetEnvasePorId(envaseId);

            ItemCarrito item = new ItemCarrito()
            {
                EnvaseId = envase.EnvaseId,
                Descripcion = envase.Descripcion,
                Precio = envase.Precio,
                Cantidad = 1
            };

            Carrito.GetInstancia().Agregar(item);
            HelperForm.MostrarDatosEnGrilla(CarritoDataGridView, Carrito.GetInstancia().listaItems);
            ActualizarTotales(Carrito.GetInstancia().GetCantidad(),
                Carrito.GetInstancia().GetTotal());
        }

        private void ActualizarTotales(int cantidad, decimal total)
        {
            CantidadLabel.Text = cantidad.ToString();
            TotalLabel.Text = total.ToString("C");
        }

        private TipoEnvase tipoEnvase;
        private void TipoEnvasesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TipoEnvasesComboBox.SelectedIndex > 0)
            {
                tipoEnvase = (TipoEnvase)TipoEnvasesComboBox.SelectedItem;
            }
            else
            {
                tipoEnvase = null;
            }

            listaEnvase = servicioEnvase.GetLista(tipoEnvase, Orden.BD);
            MostrarListaEnLayout();
        }
        private Cliente cliente;
        private void ClientesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClientesComboBox.SelectedIndex > 0)
            {
                cliente = (Cliente)ClientesComboBox.SelectedItem;
            }
            else
            {
                cliente = null;
            }

            listaCliente = servicioCliente.GetLista();
            MostrarListaEnLayout();
        }
        private Vendedor vendedor;
        private void VendedoresComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (VendedoresComboBox.SelectedIndex > 0)
            {
                vendedor = (Vendedor)VendedoresComboBox.SelectedItem;
            }
            else
            {
                vendedor = null;
            }

            listaVendedor = servicioVendedor.GetLista(Orden.BD);
            MostrarListaEnLayout();
        }

        private void CarritoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var r = CarritoDataGridView.SelectedRows[0];
            var item = (ItemCarrito)r.Tag;
            if (e.ColumnIndex == 4)
            {
                Carrito.GetInstancia().Agregar(item);
            }

            if (e.ColumnIndex == 5)
            {
                Carrito.GetInstancia().QuitarUno(item);

            }
            HelperForm.MostrarDatosEnGrilla(CarritoDataGridView, Carrito.GetInstancia().listaItems);
            ActualizarTotales(Carrito.GetInstancia().GetCantidad(),
                Carrito.GetInstancia().GetTotal());
        }

        private void CancelarIconButton_Click(object sender, EventArgs e)
        {

        }

        private Venta venta;
        private IServicioEnvases servicioEnvases;

        private void OKIconButton_Click(object sender, EventArgs e)
        {
            if (Carrito.GetInstancia().GetCantidad() == 0)
            {
                return;
            }

            venta = new Venta
            {

                FechaVenta = DateTime.Now,
                Total = Carrito.GetInstancia().GetTotal(),
                Estado = EstadoVenta.Proceso,
                DetalleVentas = ConstruirDetallesVenta(Carrito.GetInstancia().GetItems)
            };
            DialogResult = DialogResult.OK;

        }

        private List<DetalleVenta> ConstruirDetallesVenta(List<ItemCarrito> items)
        {
            var lista = new List<DetalleVenta>();
            foreach (var item in items)
            {
                DetalleVenta dv = ConstruirDetalleVenta(item);
                lista.Add(dv);
            }

            return lista;

        }

        private DetalleVenta ConstruirDetalleVenta(ItemCarrito item)
        {
            return new DetalleVenta
            {
                EnvaseId = item.EnvaseId,
                //ClienteId = item.ClienteId,
                //VendedorId = item.VendedorId,
                PrecioVenta = item.Precio,
                Cantidad = item.Cantidad
            };
        }

        public Venta GetVenta()
        {
            return venta;
        }

      
    }
}
