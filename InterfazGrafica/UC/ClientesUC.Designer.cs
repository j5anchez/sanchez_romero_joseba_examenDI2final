
namespace InterfazGrafica.UC
{
    partial class ClientesUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Base = new System.Windows.Forms.Panel();
            this.but_SeleccionarCliente = new System.Windows.Forms.Button();
            this.comboBox_Clientes = new System.Windows.Forms.ComboBox();
            this.lab_ListaClientes = new System.Windows.Forms.Label();
            this.panel_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Base
            // 
            this.panel_Base.AutoSize = true;
            this.panel_Base.Controls.Add(this.but_SeleccionarCliente);
            this.panel_Base.Controls.Add(this.comboBox_Clientes);
            this.panel_Base.Controls.Add(this.lab_ListaClientes);
            this.panel_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Base.Location = new System.Drawing.Point(0, 0);
            this.panel_Base.Margin = new System.Windows.Forms.Padding(0);
            this.panel_Base.Name = "panel_Base";
            this.panel_Base.Size = new System.Drawing.Size(892, 544);
            this.panel_Base.TabIndex = 0;
            // 
            // but_SeleccionarCliente
            // 
            this.but_SeleccionarCliente.Location = new System.Drawing.Point(405, 283);
            this.but_SeleccionarCliente.Name = "but_SeleccionarCliente";
            this.but_SeleccionarCliente.Size = new System.Drawing.Size(75, 23);
            this.but_SeleccionarCliente.TabIndex = 2;
            this.but_SeleccionarCliente.Text = "Seleccionar";
            this.but_SeleccionarCliente.UseVisualStyleBackColor = true;
            this.but_SeleccionarCliente.Click += new System.EventHandler(this.but_SeleccionarCliente_Click);
            // 
            // comboBox_Clientes
            // 
            this.comboBox_Clientes.FormattingEnabled = true;
            this.comboBox_Clientes.Location = new System.Drawing.Point(369, 256);
            this.comboBox_Clientes.Name = "comboBox_Clientes";
            this.comboBox_Clientes.Size = new System.Drawing.Size(150, 21);
            this.comboBox_Clientes.TabIndex = 1;
            this.comboBox_Clientes.SelectedIndexChanged += new System.EventHandler(this.but_SeleccionarCliente_Click);
            // 
            // lab_ListaClientes
            // 
            this.lab_ListaClientes.AutoSize = true;
            this.lab_ListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_ListaClientes.Location = new System.Drawing.Point(365, 218);
            this.lab_ListaClientes.Name = "lab_ListaClientes";
            this.lab_ListaClientes.Size = new System.Drawing.Size(163, 24);
            this.lab_ListaClientes.TabIndex = 0;
            this.lab_ListaClientes.Text = "Lista de Clientes";
            // 
            // ClientesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_Base);
            this.Name = "ClientesUC";
            this.Size = new System.Drawing.Size(892, 544);
            this.panel_Base.ResumeLayout(false);
            this.panel_Base.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Base;
        private System.Windows.Forms.ComboBox comboBox_Clientes;
        private System.Windows.Forms.Label lab_ListaClientes;
        private System.Windows.Forms.Button but_SeleccionarCliente;
    }
}
