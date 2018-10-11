using SistemasOperativos.Gestores;
using SistemasOperativos.Programas;
using SistemasOperativos.Programas.Interfaces;
using SistemasOperativos.Programas.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasOperativos.Programas.Interfaces
{
    public partial class EscritorioInterfaz : Form
    {

        EscritorioProceso miProceso;

        public EscritorioInterfaz()
        {
            InitializeComponent();

            GestorMemoria gestorMemoria = GestorMemoria.Instancia;
            GestorProgramas gestorProgramas = GestorProgramas.Instancia;
            GestorProcesos gestorProcesos = GestorProcesos.Instancia;


            miProceso = EscritorioProceso.Instancia;
            miProceso.Configurar(this);

            gestorProgramas.ExploradorArchivos.Abrir();

            foreach (Control control in escritorioPanel.Controls)
            {
                ControlExtension.Draggable(control, true);
            }
        }

        public void AgregarVentanaProceso(ProcesoInterfaz ventana, ToolStripMenuItem itemMenu)
        {
            escritorioPanel.Controls.Add(ventana);
            menuStrip1.Items.Add(itemMenu);
            ventana.BringToFront();
            ControlExtension.Draggable(ventana, true);
        }


        private void busquedaToolStripMenuItem_Enter(object sender, EventArgs e)
        {
            busquedaToolStripMenuItem.Text = "";
        }

        private void busquedaToolStripMenuItem_Leave(object sender, EventArgs e)
        {
            busquedaToolStripMenuItem.Text = "Buscar...";
        }

        private void relojToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
