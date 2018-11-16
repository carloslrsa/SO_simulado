using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasOperativos.Estructuras
{
    [System.Serializable]
    public class Usuario
    {
        private string nombre;
        private string contrasena;

        public Usuario(string nombre, string contrasena)
        {
            this.nombre = nombre;
            this.contrasena = contrasena;
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Contrasena
        {
            get
            {
                return contrasena;
            }
            set
            {
                contrasena = value;
            }
        }

    }
}
