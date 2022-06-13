using BusinessLogicLayer;
using DataAccessLayer;
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

namespace InterfazGrafica.UC
{
    public partial class ClientesUC : UserControl
    {
        #region Atributos

        /// <summary>
        /// Indice del cliente que se ha seleccionado
        /// </summary>
        private int indiceCliente = -1;

        private ClienteDTO clinteSeleccionado;

        private List<ClienteDTO> listaClientes;

        private String idClienteSeleccionado;

        /// <summary>
        /// Delegado para llamar al metodo del DashBoard
        /// </summary>
        public delegate void ClickButton();
        public event ClickButton ClienteSeleccionado;

        #endregion

        #region Constructor

        public ClientesUC()
        {
            InitializeComponent();

            // TODO: Pedir la lista de clientes a la BD 
            listaClientes=ControladorBLL.PedirListaClientes();
            // TODO: cargar la lista de clientes en el combobox (la lista la teneis como atributo en este UC) 
            SqlCommand command;

            // Objeto para elctura de datos
            SqlDataReader dataReader;
            List<string> listaClientes2 = new List<string>();
            SqlConnection conexion = new SqlConnection("Data Source=localhost;Initial Catalog=Northwind;User ID=usuarioDI;Password=1234");


            try
            {
                string customerID = string.Empty;
                string companyName = string.Empty;
                conexion.Open();
                String consultaSQL = "select * from customers";
                command = new SqlCommand(consultaSQL, conexion);

                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    customerID = dataReader.GetString(0);
                    companyName = dataReader.GetString(1);
                    listaClientes2.Add(customerID + " " + companyName);
                }

                dataReader.Close();
                command.Dispose();

                comboBox_Clientes.DataSource = listaClientes2;

            }
            catch
            {
                Exception ex;
            }

        }
        #endregion

        #region Propiedades
        public int IndiceCliente { get => indiceCliente; set => indiceCliente = value; }
        public ClienteDTO ClinteSeleccionado { get => clinteSeleccionado; set => clinteSeleccionado = value; }
        public List<ClienteDTO> ListaClientes { get => listaClientes; set => listaClientes = value; }
        public string IDClienteSeleccionado { get => idClienteSeleccionado; set => idClienteSeleccionado = value; }


        #endregion

        #region Metodos

        #endregion

        #region Eventos


        private void but_SeleccionarCliente_Click(object sender, EventArgs e)
        {
            int indiceClienteSeleccionado = this.comboBox_Clientes.SelectedIndex;


            if (indiceClienteSeleccionado < 0)
            {
                MessageBox.Show("Por favor, para continuar seleciona un cliente", "Cliente no seleccionado");
            }
            else
            {
                this.ClinteSeleccionado = this.listaClientes[indiceClienteSeleccionado];
                this.idClienteSeleccionado = ClinteSeleccionado.IDCliente;
                
                // metodo delegado asociado al Dashboard
                //ClienteSeleccionado();
                InterfazGrafica.Formularios.DashBoard db=new Formularios.DashBoard();
                //db.SeleccionCliente(indiceClienteSeleccionado.ToString(), clinteSeleccionado.ToString());
                db.SeleccionCliente(indiceClienteSeleccionado.ToString(), idClienteSeleccionado);
            }
        }
        #endregion


    }
}
