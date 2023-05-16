using ClasesCarniceria;
using ClasesCarniceria.TipoProducto;
using ClasesCarniceria.TipoUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialLaboratorio2023
{
    public partial class FormTicketFinal : Form
    {
        private double totalCarrito;
        private List<Producto> carritoFinal;
        FormVenta formVenta;
        Cliente cliente;
        public FormTicketFinal()
        {
            InitializeComponent();
        }

        public FormTicketFinal(double totalCarrito, List<Producto> carritoFinal, Cliente cliente, FormVenta formVenta) : this()
        {
            this.cliente = cliente;
            this.formVenta = formVenta;
            this.totalCarrito = totalCarrito;
            this.carritoFinal = carritoFinal;
        }

        private void FormTicketFinal_Load(object sender, EventArgs e)
        {
            this.labelDineroCliente.Text = $"Mi banco: {cliente.Dinero}";
            this.labelTotalCarrito.Text = $"Total a pagar: {totalCarrito}";
            ActualizarDGVFinal();
        }

        private void ActualizarDGVFinal()
        {
            if (carritoFinal.Count > 0)
            {
                dataGridViewCarritoFinal.DataSource = null;
                dataGridViewCarritoFinal.Visible = true;
                dataGridViewCarritoFinal.DataSource = carritoFinal;
            }
            else
            {
                dataGridViewCarritoFinal.Visible = false;
            }
        }

        private void buttonFinalizarCompra_Click(object sender, EventArgs e)
        {
            bool esCompraConCredito = radioButtonCredito.Checked;

            if (Sistema.CalcularACobrarCliente(cliente, totalCarrito, esCompraConCredito))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Se realizo la compra con exito");
                sb.AppendLine($"Le restan: {cliente.Dinero} pesos.");
                if (esCompraConCredito)
                {
                    sb.AppendLine("Al haber sido con credito, se le cobro 5% recarga...");
                }
                MessageBox.Show(sb.ToString());
                this.DialogResult = DialogResult.OK;
                formVenta.Show();
            }
            else
            {
                MessageBox.Show("Hubo un error con su compra");
            }
        }
        private void FormTicketFinal_FormClosed(object sender, FormClosedEventArgs e)
        {
            formVenta.Show();
        }

        private void buttonFinalizarCompra_MouseEnter(object sender, EventArgs e)
        {
            buttonFinalizarCompra.BackColor = Color.Gold;
        }

        private void buttonFinalizarCompra_MouseLeave(object sender, EventArgs e)
        {
            buttonFinalizarCompra.BackColor = Color.White;
        }
    }
}
