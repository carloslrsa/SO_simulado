using SistemasOperativos.Estructuras;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasOperativos.Gestores
{
    public class Gestorusuarios
    {
        #region Singleton
        private static Gestorusuarios instancia = null;

        public static Gestorusuarios Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new Gestorusuarios();
                }
                return instancia;
            }
        }

        private Gestorusuarios() { }

        #endregion

        private Usuario usuario = null;

        public Usuario UsuarioActivo
        {
            get
            {
                return usuario;
            }
            set
            {
                usuario = value;
            }
        }

    }
}
