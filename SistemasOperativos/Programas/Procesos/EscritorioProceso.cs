using SistemasOperativos.Programas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasOperativos.Programas.Procesos
{
    public class EscritorioProceso
    {
        #region Singleton
        private static EscritorioProceso instancia;

        public static EscritorioProceso Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new EscritorioProceso();
                return instancia;
            }
        }
        #endregion

        private EscritorioInterfaz interfaz = null;

        public void Configurar(EscritorioInterfaz interfaz)
        {
            this.interfaz = interfaz;
        }

        public void AgregarVentana(ProcesoInterfaz ventana, ToolStripMenuItem itemMenu)
        {
            if (interfaz != null)
            {
                interfaz.AgregarVentanaProceso(ventana, itemMenu);
            }
        }
        
    }
}
