using ClasesCarniceria;
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
    public partial class FormCrearCuenta : Form
    {
        FormLogin formLogin;
        private string nombre;
        private string apellido;
        private int dni;
        private bool dniValido;
        private string nombreUsuario;
        private string password;
        private string email;
        private int id;

        public FormLogin FormLogin { get => formLogin; set => formLogin = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int Id { get => id; set => id = value; }

        public FormCrearCuenta(FormLogin formLogin)
        {
            InitializeComponent();
            this.formLogin = formLogin;
        }


        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            lecturaInformarcion();

            id = Sistema.UsuariosRegistrados.Count + 1;

            if (radioButtonCliente.Checked)
            {
                Cliente auxCliente = new Cliente(Nombre, Apellido, Dni, NombreUsuario, Password, Email, id);
                Sistema.AgregarCliente(auxCliente);

            }
            else
            {
                Vendedor auxVendedor = new Vendedor(Nombre, Apellido, Dni, NombreUsuario, Password, Email, id);
                BaseDeDatos.ListaVendedores.Add(auxVendedor);
            }

            this.Hide();
        }

        private void lecturaInformarcion()
        {

            this.nombre = textBoxNombre.Text;
            this.apellido = textBoxApellido.Text;
            dniValido = int.TryParse(textBoxDni.Text, out this.dni);
            this.nombreUsuario = textBoxNombreUsuario.Text;
            this.email = textBoxEmail.Text;
            this.password = textBoxPassword.Text;
        }
    }
}
