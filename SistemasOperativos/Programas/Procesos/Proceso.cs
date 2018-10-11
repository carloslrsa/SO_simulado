using SistemasOperativos.Gestores;
using SistemasOperativos.Programas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasOperativos.Programas.Procesos
{
    public class Proceso
    {
        protected ProcesoInterfaz interfaz;
        protected ToolStripMenuItem menuItem;
        protected string nombrePrograma = "";

        public Proceso()
        {
            Inicializar();
            menuItem = new ToolStripMenuItem();
            menuItem.Click += MenuItem_Click;
            menuItem.Text = nombrePrograma;
            configurarVentana();


            GestorProcesos.Instancia.RegistrarProceso(this);

        }

        public virtual void Inicializar()
        {
            nombrePrograma = "Programa base";
            interfaz = new ProcesoInterfaz(this);
        }

        private void configurarVentana()
        {
            if(interfaz != null)
            {
                interfaz.Location = new System.Drawing.Point(100, 100);
                EscritorioProceso.Instancia.AgregarVentana(interfaz,menuItem);
            }
        }


        public virtual void Terminar()
        {
            GestorProcesos.Instancia.TerminarProceso(this);

            interfaz.Dispose();
            menuItem.Dispose();
        }



        private void MenuItem_Click(object sender, EventArgs e)
        {
            interfaz.Visible = true;
            interfaz.BringToFront();
        }


        public ProcesoInterfaz Ventana
        {
            get
            {
                return interfaz;
            }
        }

        public ToolStripMenuItem MenuItem
        {
            get
            {
                return menuItem;
            }
        }

        public string NombrePrograma
        {
            get
            {
                return nombrePrograma;
            }
        }
    }
}
