using ClasesCarniceria;
using ClasesCarniceria.TipoProducto;
using ClasesCarniceria.TipoUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLaboratorio2023
{
    public partial class FormHeladera : Form
    {
        Usuario usuario;
        FormLogin formLogin;
        private List<Producto> carrito;
        private List<Cliente> clientes;
        public FormHeladera()
        {
            InitializeComponent();
            this.carrito = BaseDeDatos.ListaProductos;
            this.clientes = BaseDeDatos.ListaClientes;
        }

        public FormHeladera(Usuario usuario, FormLogin formLogin) : this()
        {
            this.usuario = usuario;
            this.formLogin = formLogin;
        }

        private void FormHeladera_Load(object sender, EventArgs e)
        {
            ActualizarDGVHeladera();
            ActualizarDGVListaClientes();
        }

        private void ActualizarDGVListaClientes()
        {
            if (clientes.Count > 0)
            {
                dataGridViewListaClientes.DataSource = null;
                dataGridViewListaClientes.Visible = true;
                dataGridViewListaClientes.DataSource = clientes;
            }
            else
            {
                dataGridViewListaProductos.Visible = false;
            }
        }

        private void ActualizarDGVHeladera()
        {
            if (carrito.Count > 0)
            {
                dataGridViewListaProductos.DataSource = null;
                dataGridViewListaProductos.Visible = true;
                dataGridViewListaProductos.DataSource = carrito;
                dataGridViewListaProductos.Columns[0].Visible = false;
                dataGridViewListaProductos.Columns[3].HeaderCell.Value = "Producto";
                dataGridViewListaProductos.Columns[1].Visible = false;
                dataGridViewListaProductos.Columns[2].Visible = false;

            }
            else
            {
                dataGridViewListaProductos.Visible = false;
            }
        }

        private void buttonInformacionProducto_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaProductos.SelectedRows.Count > 0)
            {
                Producto producto = (Producto)dataGridViewListaProductos.SelectedRows[0].DataBoundItem;
                MessageBox.Show(producto.DevolverInfoProducto());
                ActualizarDGVHeladera();
            }
        }

        private void buttonVenderACliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaClientes.SelectedRows.Count > 0)
            {
                Cliente cliente = (Cliente)dataGridViewListaClientes.SelectedRows[0].DataBoundItem;
                if (cliente.Dinero > 0)
                {
                    FormVenderProductoACliente formVenderProductoACliente = new FormVenderProductoACliente(cliente);
                    this.Hide();
                    formVenderProductoACliente.Show();
                }
                else
                {
                    MessageBox.Show("No tiene dinero");
                }
            }
        }
    }
}
