using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.TipoProducto
{
    public class Variedad : Producto
    {
        private eTipoVariedad tipoVariedad;
        public eTipoVariedad TipoVariedad { get => tipoVariedad; set => tipoVariedad = value; }

        public override string Corte => DevolverTipoCorte();

        public Variedad(eTipoVariedad tipoVariedad, double peso, double precio) : base(peso, precio)
        {
            this.tipoVariedad = tipoVariedad;
        }
        public Variedad(string tipo, eTipoVariedad tipoVariedad, double peso, double precio) : this(tipoVariedad, peso, precio)
        {
            Tipo = tipo;
        }

        public override string DevolverInfoProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.DevolverInfoProducto());
            sb.AppendLine($"Tipo Variedad: {tipoVariedad.ToString()}");
            
            return sb.ToString();
        }

        public override string DevolverTipoCorte()
        {
            return tipoVariedad.ToString();
        }
    }
}
