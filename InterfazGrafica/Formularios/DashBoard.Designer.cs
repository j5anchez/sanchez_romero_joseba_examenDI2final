
namespace InterfazGrafica.Formularios
{
    partial class DashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tLP_Base = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.but_Resumen = new System.Windows.Forms.Button();
            this.but_ListaPedidos = new System.Windows.Forms.Button();
            this.but_Clientes = new System.Windows.Forms.Button();
            this.tLP_Superior = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_BaseDashboard = new System.Windows.Forms.Panel();
            this.tLP_Base.SuspendLayout();
            this.tLP_Menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLP_Base
            // 
            this.tLP_Base.BackColor = System.Drawing.Color.Transparent;
            this.tLP_Base.ColumnCount = 2;
            this.tLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.01942F));
            this.tLP_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.98058F));
            this.tLP_Base.Controls.Add(this.tLP_Menu, 0, 1);
            this.tLP_Base.Controls.Add(this.tLP_Superior, 1, 0);
            this.tLP_Base.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tLP_Base.Controls.Add(this.panel_BaseDashboard, 1, 1);
            this.tLP_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Base.Location = new System.Drawing.Point(0, 0);
            this.tLP_Base.Margin = new System.Windows.Forms.Padding(0);
            this.tLP_Base.Name = "tLP_Base";
            this.tLP_Base.RowCount = 2;
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.931699F));
            this.tLP_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.0683F));
            this.tLP_Base.Size = new System.Drawing.Size(1030, 571);
            this.tLP_Base.TabIndex = 0;
            // 
            // tLP_Menu
            // 
            this.tLP_Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.tLP_Menu.ColumnCount = 1;
            this.tLP_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Menu.Controls.Add(this.but_Resumen, 0, 2);
            this.tLP_Menu.Controls.Add(this.but_ListaPedidos, 0, 1);
            this.tLP_Menu.Controls.Add(this.but_Clientes, 0, 0);
            this.tLP_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Menu.Location = new System.Drawing.Point(0, 51);
            this.tLP_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.tLP_Menu.Name = "tLP_Menu";
            this.tLP_Menu.RowCount = 9;
            this.tLP_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLP_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLP_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLP_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLP_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLP_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLP_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLP_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLP_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tLP_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP_Menu.Size = new System.Drawing.Size(268, 520);
            this.tLP_Menu.TabIndex = 0;
            // 
            // but_Resumen
            // 
            this.but_Resumen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_Resumen.Enabled = false;
            this.but_Resumen.FlatAppearance.BorderSize = 0;
            this.but_Resumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Resumen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Resumen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_Resumen.Location = new System.Drawing.Point(0, 114);
            this.but_Resumen.Margin = new System.Windows.Forms.Padding(0);
            this.but_Resumen.Name = "but_Resumen";
            this.but_Resumen.Size = new System.Drawing.Size(268, 57);
            this.but_Resumen.TabIndex = 2;
            this.but_Resumen.Text = "Resumen";
            this.but_Resumen.UseVisualStyleBackColor = true;
            this.but_Resumen.Click += new System.EventHandler(this.but_Resumen_Click);
            // 
            // but_ListaPedidos
            // 
            this.but_ListaPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_ListaPedidos.Enabled = false;
            this.but_ListaPedidos.FlatAppearance.BorderSize = 0;
            this.but_ListaPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_ListaPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_ListaPedidos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_ListaPedidos.Location = new System.Drawing.Point(0, 57);
            this.but_ListaPedidos.Margin = new System.Windows.Forms.Padding(0);
            this.but_ListaPedidos.Name = "but_ListaPedidos";
            this.but_ListaPedidos.Size = new System.Drawing.Size(268, 57);
            this.but_ListaPedidos.TabIndex = 1;
            this.but_ListaPedidos.Text = "Lista Pedidos";
            this.but_ListaPedidos.UseVisualStyleBackColor = true;
            this.but_ListaPedidos.Click += new System.EventHandler(this.but_ListaPedidos_Click);
            // 
            // but_Clientes
            // 
            this.but_Clientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_Clientes.FlatAppearance.BorderSize = 0;
            this.but_Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Clientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Clientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_Clientes.Location = new System.Drawing.Point(0, 0);
            this.but_Clientes.Margin = new System.Windows.Forms.Padding(0);
            this.but_Clientes.Name = "but_Clientes";
            this.but_Clientes.Size = new System.Drawing.Size(268, 57);
            this.but_Clientes.TabIndex = 0;
            this.but_Clientes.Text = "Clientes";
            this.but_Clientes.UseVisualStyleBackColor = true;
            this.but_Clientes.Click += new System.EventHandler(this.but_Clientes_Click);
            // 
            // tLP_Superior
            // 
            this.tLP_Superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tLP_Superior.ColumnCount = 1;
            this.tLP_Superior.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Superior.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Superior.Location = new System.Drawing.Point(268, 0);
            this.tLP_Superior.Margin = new System.Windows.Forms.Padding(0);
            this.tLP_Superior.Name = "tLP_Superior";
            this.tLP_Superior.RowCount = 1;
            this.tLP_Superior.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Superior.Size = new System.Drawing.Size(762, 51);
            this.tLP_Superior.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 51);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(75, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_BaseDashboard
            // 
            this.panel_BaseDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_BaseDashboard.Location = new System.Drawing.Point(271, 54);
            this.panel_BaseDashboard.Name = "panel_BaseDashboard";
            this.panel_BaseDashboard.Size = new System.Drawing.Size(756, 514);
            this.panel_BaseDashboard.TabIndex = 3;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 571);
            this.Controls.Add(this.tLP_Base);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.tLP_Base.ResumeLayout(false);
            this.tLP_Menu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Base;
        private System.Windows.Forms.TableLayoutPanel tLP_Menu;
        private System.Windows.Forms.Button but_Clientes;
        private System.Windows.Forms.TableLayoutPanel tLP_Superior;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button but_Resumen;
        private System.Windows.Forms.Button but_ListaPedidos;
        private System.Windows.Forms.Panel panel_BaseDashboard;
    }
}