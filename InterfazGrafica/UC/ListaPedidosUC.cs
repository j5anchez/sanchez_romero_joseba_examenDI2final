using BusinessLogicLayer;
using ObjetosTransferencia.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica.UC
{
    public partial class ListaPedidosUC : UserControl
    {
        private List<PedidoDTO> listaPedidos;

        public ListaPedidosUC(String nombreCliente)
        {
            InitializeComponent();

            // haz la peticion de los pedidos y asociala a la lista y cargalo en el DataGridView
            listaPedidos = ControladorBLL.ListarPedidosCliente(nombreCliente);

            // cargar datos
            CargarDatosPedidotDataGridView();

        }

        public ListaPedidosUC()
        {
            InitializeComponent();


        }

        public List<PedidoDTO> ListaPedidos { get => listaPedidos; set => listaPedidos = value; }

        private void CargarDatosPedidotDataGridView()
        {
            dGV_Pedidos.Rows.Clear();
            dGV_Pedidos.Refresh();
            var source = new BindingSource();
            source.DataSource = listaPedidos;
            dGV_Pedidos.DataSource = source;


        }
    }
}
