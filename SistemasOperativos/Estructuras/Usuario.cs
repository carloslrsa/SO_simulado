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



        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

    }
}
