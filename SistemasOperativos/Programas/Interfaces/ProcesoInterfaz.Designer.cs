namespace SistemasOperativos.Programas.Interfaces
{
    partial class ProcesoInterfaz
    {

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
        public virtual void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesoInterfaz));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.minimizarBoton = new System.Windows.Forms.Button();
            this.cerrarBoton = new System.Windows.Forms.Button();
            this.contenedorPanel = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.minimizarBoton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cerrarBoton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(140, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // minimizarBoton
            // 
            this.minimizarBoton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minimizarBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizarBoton.BackgroundImage")));
            this.minimizarBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizarBoton.FlatAppearance.BorderSize = 0;
            this.minimizarBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.minimizarBoton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.minimizarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizarBoton.Location = new System.Drawing.Point(82, 7);
            this.minimizarBoton.Margin = new System.Windows.Forms.Padding(6);
            this.minimizarBoton.Name = "minimizarBoton";
            this.minimizarBoton.Size = new System.Drawing.Size(46, 44);
            this.minimizarBoton.TabIndex = 1;
            this.minimizarBoton.UseVisualStyleBackColor = true;
            this.minimizarBoton.Click += new System.EventHandler(this.minimizarBoton_Click);
            this.minimizarBoton.MouseEnter += new System.EventHandler(this.botonControl_Enter);
            this.minimizarBoton.MouseLeave += new System.EventHandler(this.botonControl_Leave);
            // 
            // cerrarBoton
            // 
            this.cerrarBoton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cerrarBoton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cerrarBoton.BackgroundImage")));
            this.cerrarBoton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cerrarBoton.FlatAppearance.BorderSize = 0;
            this.cerrarBoton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.cerrarBoton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.cerrarBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarBoton.Location = new System.Drawing.Point(12, 7);
            this.cerrarBoton.Margin = new System.Windows.Forms.Padding(6);
            this.cerrarBoton.Name = "cerrarBoton";
            this.cerrarBoton.Size = new System.Drawing.Size(46, 44);
            this.cerrarBoton.TabIndex = 0;
            this.cerrarBoton.UseVisualStyleBackColor = true;
            this.cerrarBoton.Click += new System.EventHandler(this.cerrarBoton_Click);
            this.cerrarBoton.MouseEnter += new System.EventHandler(this.botonControl_Enter);
            this.cerrarBoton.MouseLeave += new System.EventHandler(this.botonControl_Leave);
            // 
            // contenedorPanel
            // 
            this.contenedorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.contenedorPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.contenedorPanel.Location = new System.Drawing.Point(4, 75);
            this.contenedorPanel.Margin = new System.Windows.Forms.Padding(6);
            this.contenedorPanel.Name = "contenedorPanel";
            this.contenedorPanel.Size = new System.Drawing.Size(1592, 1075);
            this.contenedorPanel.TabIndex = 1;
            // 
            // labelNombre
            // 
            this.labelNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNombre.Enabled = false;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(4, 0);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(1592, 60);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "label1";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNombre.Click += new System.EventHandler(this.labelNombre_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // InterfazProceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.contenedorPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelNombre);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "InterfazProceso";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.Size = new System.Drawing.Size(1600, 1154);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InterfazProceso_MouseDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected System.Windows.Forms.Button minimizarBoton;
        protected System.Windows.Forms.Button cerrarBoton;
        protected System.Windows.Forms.Panel contenedorPanel;
        protected System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        protected System.ComponentModel.IContainer components;
    }
}
