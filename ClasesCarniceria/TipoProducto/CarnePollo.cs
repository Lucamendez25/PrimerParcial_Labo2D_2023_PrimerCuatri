using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.TipoProducto
{
    public class CarnePollo : Producto
    {
        private eTipoCortePollo tipoCorte;
        public eTipoCortePollo TipoCorte { get => tipoCorte; set => tipoCorte = value; }

        public override string Corte => DevolverTipoCorte();

        public CarnePollo(eTipoCortePollo tipoCorte, double peso, double precio) : base(peso, precio)
        {
            this.tipoCorte = tipoCorte;
        }                 
        public CarnePollo(string tipo, eTipoCortePollo tipoCorte, double peso, double precio) : this(tipoCorte, peso, precio)
        {
           this.tipo = tipo;
        }
        public override string DevolverInfoProducto()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.DevolverInfoProducto());
            sb.Append($"Tipo Corte: {tipoCorte.ToString()}");
            return sb.ToString();
        }
        public override string DevolverTipoCorte()
        {
            return tipoCorte.ToString();
        }


    }
}
