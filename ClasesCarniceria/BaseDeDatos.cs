using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesCarniceria.TipoProducto;
using ClasesCarniceria.TipoUsuario;

namespace ClasesCarniceria
{
    public static class BaseDeDatos
    {

        static List<Cliente> listaClientes;
        static List<Vendedor> listaVendedores;
        static List<Producto> listaProductos;

        static Dictionary<eTipoCorteRes, double> tiposCortesRes;
        static Dictionary<eTipoCortePollo, double> tiposCortesPollo;
        static Dictionary<eTipoVariedad, double> tiposVariedad;

        public static List<Cliente> ListaClientes { get => listaClientes; set => listaClientes = value; }
        public static List<Vendedor> ListaVendedores { get => listaVendedores; set => listaVendedores = value; }
        public static List<Producto> ListaProductos { get => listaProductos; set => listaProductos = value; }
        public static Dictionary<eTipoCortePollo, double> TiposCortesPollo { get => tiposCortesPollo; set => tiposCortesPollo = value; }
        public static Dictionary<eTipoVariedad, double> TiposVariedad { get => tiposVariedad; set => tiposVariedad = value; }
        public static Dictionary<eTipoCorteRes, double> TiposCortesRes { get => tiposCortesRes; set => tiposCortesRes = value; }
       

        static BaseDeDatos()
        {
            listaClientes = new List<Cliente>();
            listaVendedores = new List<Vendedor>();
      
            tiposCortesRes = new Dictionary<eTipoCorteRes, double>();
            tiposCortesPollo = new Dictionary<eTipoCortePollo, double>();
            tiposVariedad = new Dictionary<eTipoVariedad, double>();

            listaProductos = new List<Producto>();


            HardcodearClientes();

            HardcodearVendedores();

            HardcodearTiposCortesRes();
            HardcodearTiposCortesPollo();
            HardcodearTiposVariedad();

            HardcodearProductos();
        }

        #region Hardcodeo Listas

        private static void HardcodearClientes()
        {
            listaClientes.Add(new Cliente("Luca", "Mendez", 45199045, "userLuca", "1234", "luca@gmail.com", 1, 1000000));
            Sistema.CargarUsuario("Luca", "Mendez", 45199045, "userLuca", "1234", "luca@gmail.com");
            listaClientes.Add(new Cliente("Isabel", "Leone", 123123, "Isabelita_Leone", "1234", "isabel@gmail.com", 2 , 0));
            Sistema.CargarUsuario("Isabel", "Leone", 123123, "Isabelita_Leone", "1234", "isabel@gmail.com");
            listaClientes.Add(new Cliente("Micaela", "Vazquez", 4332211, "Mauroln", "1234", "micaela@gmail.com", 3, 0));
            Sistema.CargarUsuario("Micaela", "Vazquez", 4332211, "Micalala", "1234", "micaela@gmail.com");
            listaClientes.Add(new Cliente("Jeronimo", "DelSol", 545421, "JeroJero", "1234", "jero@gmail.com", 4, 0));
            Sistema.CargarUsuario("Jeronimo", "DelSol", 545421, "JeroJero", "1234", "jero@gmail.com");
        }



        private static void HardcodearVendedores()
        {
            listaVendedores.Add(new Vendedor("Mauro", "Maurito", 12345678, "Mauronl", "1234", "mauro@gmail.com", 5));
            Sistema.CargarUsuario("Mauro", "Maurito", 12345678, "Mauronl", "1234", "mauro@gmail.com");
            listaVendedores.Add(new Vendedor("Nathan", "Sullivan", 123123, "nathanFit", "1234", "Nathan@gmail.com", 6));
            Sistema.CargarUsuario("Nathan", "Sullivan", 1223123, "nathanFit", "1234", "nathan@gmail.com");
        }


        #endregion

        #region HardCodear Productos

        private static void HardcodearTiposCortesRes()
        {
            tiposCortesRes.Add(eTipoCorteRes.nalga, 1500);
            tiposCortesRes.Add(eTipoCorteRes.cuadrada, 1200);
            tiposCortesRes.Add(eTipoCorteRes.asado, 1700);
            tiposCortesRes.Add(eTipoCorteRes.vacio, 2000);
        }

        private static void HardcodearTiposCortesPollo()
        {
            tiposCortesPollo.Add(eTipoCortePollo.pata, 1000);
            tiposCortesPollo.Add(eTipoCortePollo.pechuga, 1200);
            tiposCortesPollo.Add(eTipoCortePollo.muslo, 700);
            tiposCortesPollo.Add(eTipoCortePollo.alita, 500);
        }

        private static void HardcodearTiposVariedad()
        {
            tiposVariedad.Add(eTipoVariedad.caritas, 300);
            tiposVariedad.Add(eTipoVariedad.mccain, 500);
            tiposVariedad.Add(eTipoVariedad.milanesaPollo, 900);
            tiposVariedad.Add(eTipoVariedad.milanesaCarne, 700);
        }

        private static void HardcodearProductos() 
        {
            foreach (var item in tiposCortesPollo)
            {
               Producto producto = new CarnePollo("Pollo",item.Key, 1 ,item.Value);  
               listaProductos.Add(producto);
            }
            foreach (var item in tiposCortesRes)
            {
                Producto producto = new CarneRes("Carne",item.Key, 1, item.Value);
                listaProductos.Add(producto);
            }
            foreach (var item in tiposVariedad)
            {
                Producto producto = new Variedad("Variedad",item.Key, 1, item.Value);
                listaProductos.Add(producto);
            }

        }
        #endregion

    }
}
