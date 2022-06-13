
namespace InterfazGrafica.UC
{
    partial class ResumenUC
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_Pedidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lab_SumaEnvio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_Pedidos
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_Pedidos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_Pedidos.Legends.Add(legend1);
            this.chart_Pedidos.Location = new System.Drawing.Point(0, 3);
            this.chart_Pedidos.Name = "chart_Pedidos";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Gastos Envio";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart_Pedidos.Series.Add(series1);
            this.chart_Pedidos.Size = new System.Drawing.Size(753, 435);
            this.chart_Pedidos.TabIndex = 0;
            this.chart_Pedidos.Text = "chart1";
            // 
            // lab_SumaEnvio
            // 
            this.lab_SumaEnvio.AutoSize = true;
            this.lab_SumaEnvio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SumaEnvio.Location = new System.Drawing.Point(121, 461);
            this.lab_SumaEnvio.Name = "lab_SumaEnvio";
            this.lab_SumaEnvio.Size = new System.Drawing.Size(116, 18);
            this.lab_SumaEnvio.TabIndex = 1;
            this.lab_SumaEnvio.Text = "Suma Gastos:";
            // 
            // ResumenUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lab_SumaEnvio);
            this.Controls.Add(this.chart_Pedidos);
            this.Name = "ResumenUC";
            this.Size = new System.Drawing.Size(836, 510);
            ((System.ComponentModel.ISupportInitialize)(this.chart_Pedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_Pedidos;
        private System.Windows.Forms.Label lab_SumaEnvio;
    }
}
