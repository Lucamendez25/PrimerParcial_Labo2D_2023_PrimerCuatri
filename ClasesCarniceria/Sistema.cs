using System.Data.Common;
using System.Runtime.InteropServices;
using ClasesCarniceria.TipoUsuario;

namespace ClasesCarniceria
{
    public static class Sistema
    {
        static List<Usuario> usuariosRegistrados;
        static List<Cliente> clientesRegistrados;
        static List<Vendedor> vendedorRegistrados;
        private const double RECARGA_CREDITO = 0.05;
        static Sistema()
        {
            usuariosRegistrados = new List<Usuario>();
            clientesRegistrados = new List<Cliente>();
            vendedorRegistrados = new List<Vendedor>();

            clientesRegistrados = BaseDeDatos.ListaClientes;
            vendedorRegistrados = BaseDeDatos.ListaVendedores;

        }
        public static List<Usuario> UsuariosRegistrados { get => usuariosRegistrados; }
        public static List<Cliente> ClientesRegistrados { get => clientesRegistrados; }
        public static List<Vendedor> VendedorRegistrados { get => vendedorRegistrados; }

        public static void CargarUsuario(string nombre, string apellido, int dni, string username, string contraseña, string email)
        {
            usuariosRegistrados.Add(new Usuario(nombre, apellido, dni, username, contraseña, email));
        }




        #region Metodos Usuario

        public static Usuario LoguearUsuario(string email, string password)
        {
            Usuario usuarioLogueado = null;

            if (ValidarCamposLogin(email, password))
            {
                foreach (Usuario auxUsuario in Sistema.UsuariosRegistrados)
                {
                    if (auxUsuario.Email == email && auxUsuario.CheckearPassword(password))
                    {
                        usuarioLogueado = auxUsuario;
                        break;
                    }
                }
            }
            return usuarioLogueado;
        }
        private static bool ValidarCamposLogin(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }

        #endregion


        #region Metodos Cliente
        public static bool AgregarCliente(Cliente cliente)
        {
            bool seAgrego = false;
            if (Sistema.ClienteExisteEnBaseDeDatos(cliente.Dni) == null)
            {
                seAgrego = true;
                BaseDeDatos.ListaClientes.Add(cliente);
                usuariosRegistrados.Add(cliente);
            }
            return seAgrego;
        }


        public static Cliente ClienteExisteEnBaseDeDatos(int dni)
        {
            Cliente clienteExistente = null;
            foreach (Cliente auxCliente in BaseDeDatos.ListaClientes)
            {
                if (dni == auxCliente.Dni)
                {
                    clienteExistente = auxCliente;
                    break;
                }
            }
            return clienteExistente;
        }
        #endregion


        #region Metodos Vendedor
        public static bool AgregarVendedor(Vendedor vendedor)
        {
            bool seAgrego = false;
            if (Sistema.ClienteExisteEnBaseDeDatos(vendedor.Dni) == null)
            {
                BaseDeDatos.ListaVendedores.Add(vendedor);
                usuariosRegistrados.Add(vendedor);
                seAgrego = true;
            }

            return seAgrego;

        }

        #endregion


        public static double DamePrecioTipoCorte(eTipoCorteRes tipoCorteRes, double precio)
        {
            foreach (var item in BaseDeDatos.TiposCortesRes)
            {
                if (tipoCorteRes == item.Key)
                {
                    return precio = item.Value;
                }
            }
            return 0;
        }

        public static double DamePrecioTipoCorte(eTipoCortePollo tipoCortePollo, double precio)
        {
            foreach (var item in BaseDeDatos.TiposCortesPollo)
            {
                if (tipoCortePollo == item.Key)
                {
                    return precio = item.Value;
                }
            }
            return 0;
        }
        public static double DamePrecioTipoCorte(eTipoVariedad tipoVariedad, double precio)
        {
            foreach (var item in BaseDeDatos.TiposVariedad)
            {
                if (tipoVariedad == item.Key)
                {
                    return precio = item.Value;
                }
            }
            return 0;
        }



        public static string[] ObtenerOpcionesPorTipo(eTipoProducto tipo) 
        {
            if (tipo is eTipoProducto.CarneRes)
            {
                return Enum.GetNames(typeof(eTipoCorteRes));
            }
            else 
            {
                if (tipo is eTipoProducto.CarnePollo)
                {
                    return Enum.GetNames(typeof(eTipoCortePollo));
                }
                else 
                {
                    return Enum.GetNames(typeof(eTipoVariedad));
                }
            }
        }

        public static bool CalcularACobrarCliente(Cliente unCliente, double totalCarrito, bool conRecarga)
        {
            bool seRealizo = false;

            if (conRecarga) 
            {
                double cantidadRecarga= totalCarrito * RECARGA_CREDITO;
                totalCarrito += cantidadRecarga;
            }
          
            if (totalCarrito < unCliente.Dinero)
            {
                unCliente.Dinero -= totalCarrito;
                seRealizo = true;
            }
            else
            {
                seRealizo = false;
            }
            return seRealizo;
        }
    }
}