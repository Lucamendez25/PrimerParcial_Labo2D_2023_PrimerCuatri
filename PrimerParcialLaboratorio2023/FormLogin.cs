using ClasesCarniceria;
using ClasesCarniceria.TipoUsuario;
using System.Text;

namespace PrimerParcialLaboratorio2023
{
    public partial class FormLogin : Form
    {
        private double dineroCliente;

        public FormLogin()
        {
            InitializeComponent();

        }
        private void FormLogin_Load(object sender, EventArgs e)
        {


        }
        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            Usuario auxUsuario = Sistema.LoguearUsuario(this.textBoxEmail.Text, this.textBoxPassword.Text);

            if (auxUsuario != null)
            {
                if (radioButtonCliente.Checked)
                {
                    foreach (Cliente cliente in BaseDeDatos.ListaClientes)
                    {

                        if (auxUsuario.Dni == cliente.Dni)
                        {
                            FormDineroCliente formDineroCliente = new FormDineroCliente(this);
                            if (formDineroCliente.ShowDialog() == DialogResult.OK)
                            {
                                dineroCliente = formDineroCliente.DineroCliente;
                                cliente.Dinero = dineroCliente;
                                FormVenta formVenta = new FormVenta(cliente, this, dineroCliente);
                                formVenta.Show();
                                this.Hide();
                            }
                        }
                    }
                }
                else
                {

                    foreach (Vendedor vendedor in BaseDeDatos.ListaVendedores)
                    {
                        if (auxUsuario.Dni == vendedor.Dni)
                        {
                            FormHeladera formHeladera = new FormHeladera(auxUsuario, this);
                            formHeladera.Show();
                            this.Hide();
                            break;
                        }
                    }

                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("ERROR:");
                sb.AppendLine("Usuario o contraseña");
                sb.AppendLine("Incorrectos");
                this.labelMensajeError.Text = sb.ToString();
                this.labelMensajeError.Visible = true;
            }
        }
        public void MostrarLogin()
        {
            this.Show();
        }

        private void buttonCrearCuenta_Click(object sender, EventArgs e)
        {
            FormCrearCuenta formCrearCuenta = new FormCrearCuenta(this);
            formCrearCuenta.Show();
        }

        private void radioButtonCliente_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxEmail.Text = "luca@gmail.com";
            this.textBoxPassword.Text = "1234";
        }

        private void radioButtonVendedor_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxEmail.Text = "mauro@gmail.com";
            this.textBoxPassword.Text = "1234";
        }

        private void buttonIngresar_MouseLeave(object sender, EventArgs e)
        {
            buttonIngresar.BackColor = Color.White;

        }

        private void buttonIngresar_MouseEnter(object sender, EventArgs e)
        {
            buttonIngresar.BackColor = Color.Gold;

        }

        private void buttonCrearCuenta_MouseLeave(object sender, EventArgs e)
        {
            buttonCrearCuenta.BackColor = Color.White;
        }

        private void buttonCrearCuenta_MouseEnter(object sender, EventArgs e)
        {
            buttonCrearCuenta.BackColor = Color.Gold;
        }
    }
}