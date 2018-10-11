using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasOperativos.Gestores;
using SistemasOperativos.Programas.Interfaces;

namespace SistemasOperativos.Programas.Procesos
{
    public class ExploradorProceso : Proceso
    {

        public override void Inicializar()
        {
            nombrePrograma = "Explorador de archivos";
            interfaz = new ExploradorInterfaz(this);
        }

        public void GenerarArbolExplorador(ref TreeView arbol)
        {
            arbol.Nodes.Clear();

            NodoDirectorio directorios =  GestorMemoria.Instancia.Directorios;

            arbol.Nodes.Add(directorios.Nombre);
            obtenerArbol(arbol.Nodes[0], directorios);

            arbol.ExpandAll();
        }

        private void obtenerArbol(TreeNode nodo, NodoDirectorio nodoDirectorio)
        {
            foreach(var n in nodoDirectorio.Nodos)
            {
                TreeNode nuevo = nodo.Nodes.Add(n.Nombre);
                obtenerArbol(nuevo, n);
            }
        }

    }
}
