using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.TipoUsuario
{
    public class Cliente : Usuario
    {
        private int id;
        private double dinero;
        public int Id { get => id; }
        public double Dinero { get => dinero; set => dinero = value; }

        public Cliente(string nombre, string apellido, int dni, string nombreUsuario, string password, string email, int id) : base(nombre, apellido, dni, nombreUsuario, password, email)

        {
            this.id = id;

        }
        public Cliente(string nombre, string apellido, int dni, string nombreUsuario, string password, string email, int id, double dinero) : this(nombre, apellido, dni, nombreUsuario, password, email, id)

        {
            this.id = id;
            this.dinero = dinero;
        }



        public override int GetHashCode()
        {
            return id;
        }

        public override string ToString()
        {
            return $"Nombre: {Nombre} \nApellido: {Apellido}\nId: {id}\nDinero: {dinero}";
        }
    }
}
