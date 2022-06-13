using ObjetosTransferencia.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    public static class AccesoDatosDAL
    {
        #region Atributos

        private static String consultaSQL;

        // TODO: insertar credenciales cadena de conexión
        /// <summary>
        ///  Cadena de conexion
        /// </summary>
        private static SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=Northwind;User ID=usuarioDI;Password=1234");

        /// <summary>
        /// lista de clientes
        /// </summary>
        private static List<ClienteDTO> listaClientes = new List<ClienteDTO>();

        /// <summary>
        /// Lista de pedidos de un cliente concreto
        /// </summary>
        private static List<PedidoDTO> listaPedidos = new List<PedidoDTO>();

        #endregion

        #region Constructores

        #endregion

        #region Propiedades

        public static string ConsultaSQL { get => consultaSQL; set => consultaSQL = value; }
        public static List<PedidoDTO> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }
        public static List<ClienteDTO> ListaClientes { get => listaClientes; set => listaClientes = value; }


        #endregion

        #region Metodos

        /// <summary>
        /// Consultar datos en una base de datos SQLServer 
        /// </summary>
        public static List<ClienteDTO> ListadoClientesNorthWind()
        {
            return RealizarConsultaClientes("select * from dbo.Customers");
        }

        /// <summary>
        /// Pide a la base de datos la lista de pedidos para un cliente concreto
        /// </summary>
        /// <param name="indiceCliente"></param>
        /// <returns></returns>
        public static List<PedidoDTO> ListadoPedidosCliente(String nombreCliente)
        {
            return RealizarConsultaPedidos("select * from dbo.Orders WHERE CustomerID = '" + nombreCliente + "'");
        }



        /// <summary>
        /// Realizar consulta a la BD
        /// </summary>
        private static List<ClienteDTO> RealizarConsultaClientes(String consulta)
        {
            SqlCommand command;

            // Objeto para elctura de datos
            SqlDataReader dataReader;

            try
            {
                conexion.Open();

                command = new SqlCommand(consulta, conexion);

                dataReader = command.ExecuteReader();
               
                while (dataReader.Read())
                {
                    // TODO: parsea los datos a la lista de ClientesDTO (campos 0 y 1 de la BD)
                   //ListaClientes.Add(dataReader.GetString(0)+" "+ dataReader.GetString(1));

                   ClienteDTO clien = new ClienteDTO(dataReader.GetString(0),dataReader.GetString(1));
                    clien.NombreCliente = dataReader.GetString(1);
                    clien.IDCliente = dataReader.GetString(0);

                    ListaClientes.Add(clien);
                  listaClientes.Add(clien);

                }

                dataReader.Close();
                command.Dispose();

                return listaClientes;


            }
            catch (Exception e)
            {
                throw new Exception("No se ha podido estabecer la conexion con la BD!" + e.Message);

            }
            finally
            {
                conexion.Close();

            }

        }


        /// <summary>
        /// Realizar consulta a la BD
        /// </summary>
        private static List<PedidoDTO> RealizarConsultaPedidos(String consulta)
        {
            SqlCommand command;

            // Objeto para elctura de datos
            SqlDataReader dataReader;

            try
            {
                conexion.Open();

                command = new SqlCommand(consulta, conexion);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    // creamos un pedido, parseamos y añadimos a la lista de clientes
                    // campos 0, 1, 3, 5, 7, 8 de la BD
                    PedidoDTO pedido = new PedidoDTO();
                    pedido.IdPedido = Int32.Parse(dataReader.GetValue(0).ToString());
                    pedido.IdCliente = dataReader.GetValue(1).ToString();
                    pedido.FechaPedido = DateTime.Parse(dataReader.GetValue(3).ToString());
                    pedido.FechaEnvio = DateTime.Parse(dataReader.GetValue(5).ToString());
                    pedido.PrecioEnvio = Double.Parse(dataReader.GetValue(7).ToString());
                    pedido.Direccion = dataReader.GetValue(8).ToString();

                    listaPedidos.Add(pedido);

                }

                dataReader.Close();
                command.Dispose();

                return listaPedidos;


            }
            catch (Exception e)
            {
                throw new Exception("No se ha podido estabecer la conexion con la BD!" + e.Message);

            }
            finally
            {
                conexion.Close();

            }

        }


        #endregion

    }
}
