using System;
using System.Collections.Generic;
using System.Text;

namespace ObjetosTransferencia.DTO
{
    public class ClienteDTO
    {
        #region Atributos
        #endregion
        private String idCliente;
        private String nombreCliente;


        #region Constructores

        public ClienteDTO(string iDCliente, string nombreCliente)
        {
            this.idCliente = iDCliente;
            this.NombreCliente = nombreCliente;
        }


        #endregion


        #region Propiedades

        public string IDCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }

        #endregion


        #region Metodos
        #endregion
    }
}
