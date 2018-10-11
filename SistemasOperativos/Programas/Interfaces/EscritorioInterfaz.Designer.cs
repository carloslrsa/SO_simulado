namespace SistemasOperativos.Programas.Interfaces
{
    partial class EscritorioInterfaz
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apagarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relojToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.escritorioPanel = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RoyalBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programasToolStripMenuItem,
            this.relojToolStripMenuItem,
            this.busquedaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1264, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            this.programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apagarToolStripMenuItem});
            this.programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            this.programasToolStripMenuItem.Size = new System.Drawing.Size(50, 37);
            this.programasToolStripMenuItem.Text = "Menú";
            // 
            // apagarToolStripMenuItem
            // 
            this.apagarToolStripMenuItem.Name = "apagarToolStripMenuItem";
            this.apagarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.apagarToolStripMenuItem.Text = "Apagar";
            // 
            // relojToolStripMenuItem
            // 
            this.relojToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.relojToolStripMenuItem.BackColor = System.Drawing.Color.RoyalBlue;
            this.relojToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.relojToolStripMenuItem.Name = "relojToolStripMenuItem";
            this.relojToolStripMenuItem.Size = new System.Drawing.Size(46, 37);
            this.relojToolStripMenuItem.Text = "12:00";
            // 
            // busquedaToolStripMenuItem
            // 
            this.busquedaToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.busquedaToolStripMenuItem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.busquedaToolStripMenuItem.Name = "busquedaToolStripMenuItem";
            this.busquedaToolStripMenuItem.Size = new System.Drawing.Size(200, 37);
            this.busquedaToolStripMenuItem.Text = "Buscar...";
            this.busquedaToolStripMenuItem.Enter += new System.EventHandler(this.busquedaToolStripMenuItem_Enter);
            this.busquedaToolStripMenuItem.Leave += new System.EventHandler(this.busquedaToolStripMenuItem_Leave);
            // 
            // escritorioPanel
            // 
            this.escritorioPanel.BackColor = System.Drawing.Color.SlateGray;
            this.escritorioPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.escritorioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.escritorioPanel.Location = new System.Drawing.Point(0, 0);
            this.escritorioPanel.Margin = new System.Windows.Forms.Padding(2);
            this.escritorioPanel.Name = "escritorioPanel";
            this.escritorioPanel.Size = new System.Drawing.Size(1264, 681);
            this.escritorioPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.escritorioPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.Panel escritorioPanel;
        private System.Windows.Forms.ToolStripMenuItem apagarToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox busquedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relojToolStripMenuItem;
    }
}

