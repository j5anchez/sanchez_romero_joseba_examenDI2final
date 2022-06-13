using System;
using System.Collections.Generic;
using System.Text;

namespace ObjetosTransferencia.DTO
{
    public class PedidoDTO
    {
        #region Atributos
        private int idPedido;
        private String idCliente;
        private DateTime fechaPedido;
        private DateTime fechaEnvio;
        private double precioEnvio;
        private String direccion;

        #endregion

        #region Constructores
        

        public PedidoDTO(int idPedido, string idCliente, DateTime fechaPedido, DateTime fechaEnvio, double precioEnvio, string direccion)
        {
            this.idPedido = idPedido;
            this.idCliente = idCliente;
            this.fechaPedido = fechaPedido;
            this.fechaEnvio = fechaEnvio;
            this.precioEnvio = precioEnvio;
            this.direccion = direccion;
        }

        public PedidoDTO()
        {
            this.idPedido = int.MaxValue;
            this.idCliente = "";
            this.fechaPedido = DateTime.Now;
            this.fechaEnvio = DateTime.Now;
            this.precioEnvio = double.MaxValue;
            this.direccion = "";
        }

        #endregion


        #region Propiedades

        public int IdPedido { get => idPedido; set => idPedido = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaPedido { get => fechaPedido; set => fechaPedido = value; }
        public DateTime FechaEnvio { get => fechaEnvio; set => fechaEnvio = value; }
        public double PrecioEnvio { get => precioEnvio; set => precioEnvio = value; }
        public string Direccion { get => direccion; set => direccion = value; }


        #endregion
    }
}
