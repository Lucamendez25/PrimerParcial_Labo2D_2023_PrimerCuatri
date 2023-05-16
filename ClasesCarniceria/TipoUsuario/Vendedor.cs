using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.TipoUsuario
{
    public class Vendedor : Usuario
    {
        private int id;
        public int Id { get => id; }
        public Vendedor(string nombre, string apellido, int dni, string nombreUsuario, string password, string email, int id) : base(nombre, apellido, dni, nombreUsuario, password, email)
        {
            this.id = id;
        }
        public override int GetHashCode()
        {
            return this.id;
        }

        public override string ToString()
        {
            return $"Nombre: {this.Nombre} \nApellido: {this.Apellido}\nId: {this.id}";
        }
    }
}
