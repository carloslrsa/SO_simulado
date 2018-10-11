using SistemasOperativos.Gestores;
using SistemasOperativos.Programas.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasOperativos.Programas.Interfaces
{
    public partial class ExploradorInterfaz : ProcesoInterfaz
    {

        public ExploradorInterfaz(Proceso proceso) : base(proceso)
        {
            ((ExploradorProceso)proceso).GenerarArbolExplorador(ref exploradorArbol);

            exploradorArbol.AfterSelect += ExploradorArbol_AfterSelect;

        }

        private void ExploradorArbol_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MostrarArchivos(e.Node.FullPath);
            ((ExploradorProceso)proceso).GenerarArbolExplorador(ref exploradorArbol);
        }


        public void MostrarArchivos(string dir)
        {
            exploradorContenido.Controls.Clear();
            archivoAnterior = null;

            foreach (var archivo in GestorMemoria.Instancia.ObtenerArchivos(dir))
            {
                ArchivoInterfaz arInterfaz = new ArchivoInterfaz(archivo);

                arInterfaz.MouseDown += ArInterfaz_MouseDown;
                arInterfaz.DoubleClick += ArInterfaz_DoubleClick;

                exploradorContenido.Controls.Add(arInterfaz);
            }
        }

        private void ArInterfaz_DoubleClick(object sender, EventArgs e)
        {
            ArchivoInterfaz archivoSeleccionado = (ArchivoInterfaz)sender;
            archivoSeleccionado.archivo.Abrir(this);

            //archivoAnterior = null;
        }

        ArchivoInterfaz archivoAnterior = null;

        private void ArInterfaz_MouseDown(object sender, MouseEventArgs e)
        {
            ArchivoInterfaz archivoSeleccionado = (ArchivoInterfaz)sender;
            if (archivoAnterior != archivoSeleccionado)
            {
                archivoSeleccionado.BackColor = Color.LightSkyBlue;

                if (archivoAnterior != null)
                {
                    archivoAnterior.BackColor = Color.Transparent;
                }

                archivoAnterior = archivoSeleccionado;
            }


        }
    }
}
