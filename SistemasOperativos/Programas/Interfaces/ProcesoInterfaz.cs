using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasOperativos.Programas.Procesos;

namespace SistemasOperativos.Programas.Interfaces
{
    public partial class ProcesoInterfaz : UserControl
    {
        private int botonControlTamanoEnter = 25;
        private int botonControlTamanoLeave = 23;
        protected Proceso proceso;

        public ProcesoInterfaz(Proceso proceso)
        {
            InitializeComponent();
            this.proceso = proceso;
            labelNombre.Text = proceso.NombrePrograma;
        }

        private void botonControl_Enter(object sender, EventArgs e)
        {
            ((Control)sender).Size = new Size(botonControlTamanoEnter, botonControlTamanoEnter);
        }

        private void botonControl_Leave(object sender, EventArgs e)
        {
            ((Control)sender).Size = new Size(botonControlTamanoLeave, botonControlTamanoLeave);
        }

        private void cerrarBoton_Click(object sender, EventArgs e)
        {
            proceso.Terminar();
        }

        private void minimizarBoton_Click(object sender, EventArgs e)
        {
            Visible = false;
        }

        private void labelNombre_Click(object sender, EventArgs e)
        {

        }

        private void InterfazProceso_MouseDown(object sender, MouseEventArgs e)
        {
            BringToFront();
        }
    }
}
