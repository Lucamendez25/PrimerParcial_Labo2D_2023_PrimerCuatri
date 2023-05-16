using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.TipoProducto
{
    public abstract class Producto
    {
        protected double peso;
        protected double precio;
        protected string tipo;
     
        public double Peso { get => peso; set => peso = value; }
        public double Precio { get => precio * peso; set => precio = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public abstract string Corte { get; }

        public Producto(double peso, double precio)
        {
            this.peso = peso;
            this.precio = precio;
        }
        public Producto(double peso, double precio, string tipo) : this(peso, precio)
        {
            this.tipo = tipo;
        }
        public virtual string DevolverInfoProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tipo: {tipo}" );
            sb.AppendLine($"Kilo: {peso.ToString()}");
            sb.AppendLine($"Precio/PorKilo: {precio.ToString()}");
            return sb.ToString();
        }
        public abstract string DevolverTipoCorte();
    }
}
