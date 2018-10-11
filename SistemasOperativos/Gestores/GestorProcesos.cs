using SistemasOperativos.Programas.Procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasOperativos.Gestores
{
    public class GestorProcesos
    {
        #region Singleton
        private static GestorProcesos instancia = null;

        public static GestorProcesos Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new GestorProcesos();
                }
                return instancia;
            }
        }

        #endregion

        private List<Proceso> procesosActivos = new List<Proceso>();

        private GestorProcesos()
        {

        }

        public void RegistrarProceso(Proceso proceso)
        {
            procesosActivos.Add(proceso);
        }

        public void TerminarProceso(Proceso proceso)
        {
            procesosActivos.Remove(proceso);
        }
    }
}
