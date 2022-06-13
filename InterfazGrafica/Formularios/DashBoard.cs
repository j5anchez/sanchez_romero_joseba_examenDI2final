using BusinessLogicLayer;
using InterfazGrafica.UC;
using ObjetosTransferencia.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica.Formularios
{
    public partial class DashBoard : Form
    {
        #region Atributos
        private static SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=Northwind;User ID=usuarioDI;Password=1234");

        private UC.BienvenidaUC bienvenidaUC;

        private ClientesUC clientesUC;

        private ListaPedidosUC listaPedidosUC;

        private ResumenUC resumenUC;

        #endregion

        #region Constructor

        public DashBoard()
        {
            InitializeComponent();

            BienvenidaUC = new UC.BienvenidaUC();
            panel_BaseDashboard.Controls.Add(BienvenidaUC);

        }

        #endregion

        #region Propiedades

        public BienvenidaUC BienvenidaUC { get => bienvenidaUC; set => bienvenidaUC = value; }
        public ClientesUC Clientes { get => clientesUC; set => clientesUC = value; }
        public ListaPedidosUC ListaPedidos { get => listaPedidosUC; set => listaPedidosUC = value; }
        public ResumenUC Resumen { get => resumenUC; set => resumenUC = value; }
        private List<PedidoDTO> listaPedidos;


        #endregion

        #region Metodos

        #endregion

        #region Eventos

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_Clientes_Click(object sender, EventArgs e)
        {

            panel_BaseDashboard.Controls.Remove(this.bienvenidaUC);

            // TODO: crear un UC ClientesUC 
            clientesUC=new ClientesUC();

            // linea para llamar al metodo delegado
            this.clientesUC.ClienteSeleccionado += new ClientesUC.ClickButton(ClientesUC_ClienteSeleccionado);
            panel_BaseDashboard.Controls.Add(this.clientesUC);




        }
        public void SeleccionCliente(string idcliente, string nombrecliente)
        {
           // panel_BaseDashboard.Controls.Remove(this.clientesUC);
            //this.listaPedidosUC = new ListaPedidosUC(this.clientesUC.IDClienteSeleccionado);
            //panel_BaseDashboard.Controls.Add(this.listaPedidosUC);
            SqlCommand command;
            but_ListaPedidos.Enabled = true;
            but_Resumen.Enabled = true;
            // Objeto para elctura de datos
            SqlDataReader dataReader;

            try
            {
                conexion.Open();

                command = new SqlCommand("select * from orders where customerid='" + nombrecliente + "'", conexion);

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

                    ListaPedidos.Add(pedido);

                }

                dataReader.Close();
                command.Dispose();
              
            }
            catch (Exception ex) { }
            finally { conexion.Close(); }



        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void but_ListaPedidos_Click(object sender, EventArgs e)
        {

            // Crear un UC de tipo "ListaPedidosUC" que tienes la lista de pedidos como atributo
            // insertar la lista en un DGV y el UC en el DashBoard
            panel_BaseDashboard.Controls.Remove(this.clientesUC);
            this.listaPedidosUC = new ListaPedidosUC(this.clientesUC.IDClienteSeleccionado);
            panel_BaseDashboard.Controls.Add(this.listaPedidosUC);

        }


        /// <summary>
        /// 
        /// </summary>
        void ClientesUC_ClienteSeleccionado()
        {
            but_ListaPedidos.Enabled = true;
            but_Resumen.Enabled = true;

        }

        private void but_Resumen_Click(object sender, EventArgs e)
        {
            // TODO: crea un UC tipo ResumenUC e insertalo en el Dashboard


        }


        #endregion


    }
}
