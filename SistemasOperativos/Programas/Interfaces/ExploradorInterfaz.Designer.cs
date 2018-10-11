using System.Windows.Forms;

namespace SistemasOperativos.Programas.Interfaces
{
    partial class ExploradorInterfaz
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

        public override void InitializeComponent()
        {
            base.InitializeComponent();
            exploradorArbol = new TreeView();
            exploradorContenido = new FlowLayoutPanel();

            contenedorPanel.Controls.Add(exploradorArbol);
            contenedorPanel.Controls.Add(exploradorContenido);


            // 
            // exploradorArbol
            // 
            this.exploradorArbol.Dock = System.Windows.Forms.DockStyle.Left;
            this.exploradorArbol.Location = new System.Drawing.Point(0, 0);
            this.exploradorArbol.Name = "exploradorArbol";
            this.exploradorArbol.Size = new System.Drawing.Size(160, 559);
            this.exploradorArbol.TabIndex = 0;
            // 
            // exploradorContenido
            // 
            this.exploradorContenido.AutoScroll = true;
            this.exploradorContenido.BackColor = System.Drawing.Color.White;
            this.exploradorContenido.Dock = System.Windows.Forms.DockStyle.Right;
            this.exploradorContenido.Location = new System.Drawing.Point(161, 0);
            this.exploradorContenido.Name = "exploradorContenido";
            this.exploradorContenido.Size = new System.Drawing.Size(635, 559);
            this.exploradorContenido.TabIndex = 1;
        }

        TreeView exploradorArbol;
        FlowLayoutPanel exploradorContenido;
    }
}
