using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesCarniceria.TipoProducto
{
    public class CarneRes : Producto
    {
        private eTipoCorteRes tipoCorte;
        public eTipoCorteRes TipoCorte { get => tipoCorte; set => tipoCorte = value; }

        public override string Corte => DevolverTipoCorte();

        public CarneRes(eTipoCorteRes tipoCorte, double peso, double precio) : base(peso, precio)
        {
            this.tipoCorte = tipoCorte;
        }
        public CarneRes(string tipo, eTipoCorteRes tipoCorte, double peso, double precio) : this(tipoCorte, peso, precio)
        {
            Tipo = tipo;
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
