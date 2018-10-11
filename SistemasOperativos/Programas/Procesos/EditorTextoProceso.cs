using SistemasOperativos.Estructuras;
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
    public class EditorTextoProceso : Proceso
    {
        Archivo archivoTexto = null;

        public EditorTextoProceso(Archivo texto = null) : base()
        {
            archivoTexto = texto;

            if(archivoTexto != null)
            {
                EditorTextoInterfaz interfaz = (EditorTextoInterfaz)this.interfaz;
                interfaz.contenidoTexto.Text = archivoTexto.Contenido;
                interfaz.direccionTexto.Visible = false;
                interfaz.nombreTexto.Visible = false;

            }
        }

        public override void Inicializar()
        {
            nombrePrograma = "Editor de texto";
            interfaz = new EditorTextoInterfaz(this);
        }

        public void Guardar(string texto, string direccion, string nombre)
        {
            if(archivoTexto == null)
            {
                archivoTexto = new Archivo(nombre, false, direccion, "Carlos", texto, TipoArchivo.Texto);

                if (!GestorMemoria.Instancia.CrearArchivo(archivoTexto))
                {
                    archivoTexto = null;
                }
            }
            else
            {
                if(archivoTexto.Contenido != texto)
                {
                    archivoTexto.Contenido = texto;
                    GestorMemoria.Instancia.ModificarArchivo(archivoTexto);
                }
            }
        }
    }
}
