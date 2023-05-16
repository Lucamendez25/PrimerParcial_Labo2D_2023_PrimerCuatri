using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.TipoUsuario
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private int dni;
        private string nombreUsuario;
        private string password;
        private string email;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Dni { get => dni; set => dni = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }

        public Usuario(string nombre, string apellido, int dni, string nombreUsuario, string password, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.nombreUsuario = nombreUsuario;
            this.password = password;
            this.email = email;
        }

        public bool CheckearPassword(string password)
        {
            return Password == password;
        }


        /// <summary>
        /// GetHashCode()
        /// </summary>
        /// <returns> Devuelve el dni, que esta en la clase padre (Persona) </returns>
        public override int GetHashCode()
        {
            return dni;
        }

        public override string ToString()
        {
            return $"\nNombre: {nombre}\nApellido{apellido}\nDni: {dni}\n Nombre de Usuario: {nombreUsuario} \n Mail: {email}";
        }
    }
}
