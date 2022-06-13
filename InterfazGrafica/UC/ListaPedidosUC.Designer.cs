
namespace InterfazGrafica.UC
{
    partial class ListaPedidosUC
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
            this.dGV_Pedidos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_Pedidos
            // 
            this.dGV_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Pedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGV_Pedidos.Location = new System.Drawing.Point(0, 0);
            this.dGV_Pedidos.Name = "dGV_Pedidos";
            this.dGV_Pedidos.Size = new System.Drawing.Size(850, 473);
            this.dGV_Pedidos.TabIndex = 0;
            // 
            // ListaPedidosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dGV_Pedidos);
            this.Name = "ListaPedidosUC";
            this.Size = new System.Drawing.Size(850, 473);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Pedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_Pedidos;
    }
}
