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
    public partial class FormVenderProductoACliente : Form
    {
        Cliente cliente;
        List<Producto> listaProductos;
        public FormVenderProductoACliente()
        {
            InitializeComponent();
            this.listaProductos = BaseDeDatos.ListaProductos;

        }
        public FormVenderProductoACliente(Cliente cliente) : this()
        {
            this.cliente = cliente;
        }
        private void FormVenderProductoACliente_Load(object sender, EventArgs e)
        {
            ActualizarDGVListaProductos();
            ActualizarCliente();
        }
        private void ActualizarDGVListaProductos()
        {
            if (listaProductos.Count > 0)
            {
                dataGridViewListaProductos.DataSource = null;
                dataGridViewListaProductos.Visible = true;
                dataGridViewListaProductos.DataSource = listaProductos;

            }
            else
            {
                dataGridViewListaProductos.Visible = false;
            }
        }

        private void ActualizarCliente()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {cliente.Nombre}");
            sb.AppendLine($"Nombre: {cliente.NombreUsuario}");
            sb.AppendLine($"Dinero: {cliente.Dinero}");
            labelUsuario.Text = sb.ToString();
        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            if (dataGridViewListaProductos.SelectedRows.Count > 0)
            {
                Producto producto = (Producto)dataGridViewListaProductos.SelectedRows[0].DataBoundItem;
                if (producto != null)
                {
                    Sistema.CalcularACobrarCliente(cliente, producto.Precio, false);
                    ActualizarCliente();
                }
            }
        }
    }
}
