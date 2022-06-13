
namespace InterfazGrafica.UC
{
    partial class BienvenidaUC
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
            this.tLP_Bienvenida_Base = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tLP_Bienvenida_Base.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_Bienvenida_Base
            // 
            this.tLP_Bienvenida_Base.AutoSize = true;
            this.tLP_Bienvenida_Base.ColumnCount = 1;
            this.tLP_Bienvenida_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Bienvenida_Base.Controls.Add(this.label1, 0, 0);
            this.tLP_Bienvenida_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Bienvenida_Base.Location = new System.Drawing.Point(0, 0);
            this.tLP_Bienvenida_Base.Margin = new System.Windows.Forms.Padding(0);
            this.tLP_Bienvenida_Base.Name = "tLP_Bienvenida_Base";
            this.tLP_Bienvenida_Base.RowCount = 1;
            this.tLP_Bienvenida_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Bienvenida_Base.Size = new System.Drawing.Size(788, 461);
            this.tLP_Bienvenida_Base.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a tu Dashboard";
            // 
            // BienvenidaUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tLP_Bienvenida_Base);
            this.Name = "BienvenidaUC";
            this.Size = new System.Drawing.Size(788, 461);
            this.tLP_Bienvenida_Base.ResumeLayout(false);
            this.tLP_Bienvenida_Base.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Bienvenida_Base;
        private System.Windows.Forms.Label label1;
    }
}
