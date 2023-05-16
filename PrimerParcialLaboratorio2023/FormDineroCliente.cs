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
    public partial class FormDineroCliente : Form
    {
        FormLogin formLogin;

        private double dineroCliente;
        public double DineroCliente { get => dineroCliente; set => dineroCliente = value; }

        public FormDineroCliente()
        {
            InitializeComponent();
        }
        public FormDineroCliente(FormLogin formLogin) : this()
        {
            this.formLogin = formLogin;
        }

        private void buttonDineroCliente_Click(object sender, EventArgs e)
        {
            string dineroClienteString;
            dineroClienteString = textBoxDineroCliente.Text;
            if (double.TryParse(dineroClienteString, out double aux))
            {
                this.dineroCliente = aux;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
            this.Hide();
        }

        private void FormDineroCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            formLogin.Show();
        }

        private void buttonDineroCliente_MouseLeave(object sender, EventArgs e)
        {
            buttonDineroCliente.BackColor = Color.White;
        }

        private void buttonDineroCliente_MouseEnter(object sender, EventArgs e)
        {
            buttonDineroCliente.BackColor = Color.Gold;
        }
    }
}
