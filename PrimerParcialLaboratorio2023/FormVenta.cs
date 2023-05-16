using ClasesCarniceria;
using ClasesCarniceria.TipoProducto;
using ClasesCarniceria.TipoUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLaboratorio2023
{
    public partial class FormVenta : Form
    {
        private Cliente cliente;
        private FormLogin formLogin;
        private double dineroCliente;
        private List<Producto> carrito;
        private double totalCarrito;

        public double TotalCarrito { get => totalCarrito; set => totalCarrito = value; }

        public FormVenta()
        {
            InitializeComponent();
            this.formLogin = new FormLogin();
            this.carrito = new List<Producto>();


            this.comboBoxTipo.Items.Add(eTipoProducto.CarneRes);
            this.comboBoxTipo.Items.Add(eTipoProducto.CarnePollo);
            this.comboBoxTipo.Items.Add(eTipoProducto.Variedad);
        }
        public FormVenta(Cliente cliente, FormLogin formLogin, double dineroCliente) : this()
        {
            this.cliente = cliente;
            this.formLogin = formLogin;
            this.dineroCliente = dineroCliente;
        }
        private void FormVenta_Load(object sender, EventArgs e)
        {
            ActualizarDatosUsuario();
            ActualizarDGVVenta();
        }

        private void ActualizarDatosUsuario()
        {
            this.labelDineroIngresado.Text = $"Usuario: {cliente.NombreUsuario}     Dinero{dineroCliente}";
        }

        private void FormVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            formLogin.MostrarLogin();
        }
        private void ActualizarDGVVenta()
        {

            if (carrito.Count > 0)
            {
                dataGridViewListaProductos.DataSource = null;
                dataGridViewListaProductos.Visible = true;
                dataGridViewListaProductos.DataSource = carrito;
                labelCarritoVacio.Visible = false;
            }
            else
            {
                labelCarritoVacio.Visible = true;
                dataGridViewListaProductos.Visible = false;
            }
            #region CodigoViejo
            //dataGridViewListaProductos.Rows.Clear();
            //foreach (Producto item in carrito)
            //{
            //    int n = dataGridViewListaProductos.Rows.Add();
            //    dataGridViewListaProductos.Rows[n].Cells[0].Value = item.Tipo;
            //    dataGridViewListaProductos.Rows[n].Cells[1].Value = item.DevolverTipoCorte();
            //    dataGridViewListaProductos.Rows[n].Cells[2].Value = item.Precio;
            //    dataGridViewListaProductos.Rows[n].Cells[3].Value = item.Peso;
            //}
            #endregion
        }
        #region CodigoViejo
        /*
       private void ActualizarDGVVenta()
       {
           dataGridViewListaProductos.DataSource = null;

           foreach (var item in BaseDeDatos.TiposCortesRes)
           {
               int n = dataGridViewListaProductos.Rows.Add();
               dataGridViewListaProductos.Rows[n].Cells[0].Value = "Carne Res";
               dataGridViewListaProductos.Rows[n].Cells[1].Value = item.Key.ToString();
               dataGridViewListaProductos.Rows[n].Cells[2].Value = item.Value.ToString();
               dataGridViewListaProductos.Rows[n].Cells[3].Value = 0;
           }

           foreach (var item in BaseDeDatos.TiposCortesPollo)
           {
               int n = dataGridViewListaProductos.Rows.Add();
               dataGridViewListaProductos.Rows[n].Cells[0].Value = "Carne Pollo";
               dataGridViewListaProductos.Rows[n].Cells[1].Value = item.Key.ToString();
               dataGridViewListaProductos.Rows[n].Cells[2].Value = item.Value.ToString();
               dataGridViewListaProductos.Rows[n].Cells[3].Value = 0;
           }

           foreach (var item in BaseDeDatos.TiposVariedad)
           {
               int n = dataGridViewListaProductos.Rows.Add();
               dataGridViewListaProductos.Rows[n].Cells[0].Value = "Variedad ";
               dataGridViewListaProductos.Rows[n].Cells[1].Value = item.Key.ToString();
               dataGridViewListaProductos.Rows[n].Cells[2].Value = item.Value.ToString();
               dataGridViewListaProductos.Rows[n].Cells[3].Value = 0;
           }
       }
       */
        #endregion
        private void comboBoxTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxTipoProducto.DataSource = null;
            eTipoProducto tipoSeleccionado = (eTipoProducto)comboBoxTipo.SelectedItem;
            comboBoxTipoProducto.DataSource = Sistema.ObtenerOpcionesPorTipo(tipoSeleccionado);
        }

        private void buttonAgregarProducto_Click(object sender, EventArgs e)
        {
            string tipo = comboBoxTipo.Text;
            double kilos = (double)numericUpDownKilos.Value;
            double precio = 0;
            eTipoProducto tipoSeleccionado = (eTipoProducto)comboBoxTipo.SelectedItem;
            switch (tipoSeleccionado)
            {
                case eTipoProducto.CarneRes:
                    eTipoCorteRes tipoCorteRes = (eTipoCorteRes)Enum.Parse(typeof(eTipoCorteRes), comboBoxTipoProducto.SelectedItem.ToString());
                    precio = Sistema.DamePrecioTipoCorte(tipoCorteRes, precio);
                    Producto productoCarne = new CarneRes(tipo, tipoCorteRes, kilos, precio);
                    ActualizarTotalDeMiCarrito(productoCarne.Precio, true);
                    carrito.Add(productoCarne);
                    break;

                case eTipoProducto.CarnePollo:
                    eTipoCortePollo tipoCortePollo = (eTipoCortePollo)Enum.Parse(typeof(eTipoCortePollo), comboBoxTipoProducto.SelectedItem.ToString());
                    precio = Sistema.DamePrecioTipoCorte(tipoCortePollo, precio);
                    Producto productoPollo = new CarnePollo(tipo, tipoCortePollo, kilos, precio);
                    ActualizarTotalDeMiCarrito(productoPollo.Precio, true);
                    carrito.Add(productoPollo);
                    break;

                case eTipoProducto.Variedad:
                    eTipoVariedad tipoVariedad = (eTipoVariedad)Enum.Parse(typeof(eTipoVariedad), comboBoxTipoProducto.SelectedItem.ToString());
                    precio = Sistema.DamePrecioTipoCorte(tipoVariedad, precio);
                    Producto productoVariedad = new Variedad(tipo, tipoVariedad, kilos, precio);
                    ActualizarTotalDeMiCarrito(productoVariedad.Precio, true);
                    carrito.Add(productoVariedad);
                    break;
            }
            ActualizarDGVVenta();
        }
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaProductos.SelectedRows.Count > 0)
            {
                Producto producto = (Producto)dataGridViewListaProductos.SelectedRows[0].DataBoundItem;
                ActualizarTotalDeMiCarrito(producto.Precio, false);
                carrito.Remove(producto);
                ActualizarDGVVenta();
            }
        }

        private void ActualizarTotalDeMiCarrito(double precio, bool sumo)
        {
            if (sumo)
            {
                TotalCarrito += precio;
            }
            else
            {
                TotalCarrito -= precio;
            }
            labelCarritoTotal.Text = "Dinero: " + TotalCarrito.ToString();
        }

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            Form formTicketFinal = new FormTicketFinal(TotalCarrito, carrito, cliente, this);
            this.Hide();
            if (formTicketFinal.ShowDialog() == DialogResult.OK)
            {
                dineroCliente = cliente.Dinero;
                ActualizarDatosUsuario();
                carrito.Clear();
                ActualizarDGVVenta();
            }
        }
        private void FormVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin.Show();
        }

        private void buttonAgregarProducto_MouseEnter(object sender, EventArgs e)
        {
            buttonAgregarProducto.BackColor = Color.Gold;
        }

        private void buttonAgregarProducto_MouseLeave(object sender, EventArgs e)
        {
            buttonAgregarProducto.BackColor = Color.White;
        }

        private void buttonEliminar_MouseEnter(object sender, EventArgs e)
        {
            buttonEliminar.BackColor = Color.Gold;
        }

        private void buttonEliminar_MouseLeave(object sender, EventArgs e)
        {
            buttonEliminar.BackColor = Color.White;
        }

        private void buttonFinalizarCompra_MouseLeave(object sender, EventArgs e)
        {
            buttonFinalizarCompra.BackColor = Color.White;
        }

        private void buttonFinalizarCompra_MouseEnter(object sender, EventArgs e)
        {
            buttonFinalizarCompra.BackColor = Color.Gold;
        }
    }
}
