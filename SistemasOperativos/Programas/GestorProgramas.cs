using SistemasOperativos.Estructuras;
using SistemasOperativos.Gestores;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasOperativos.Programas
{
    public class GestorProgramas
    {
        #region Singleton   
        private static GestorProgramas instancia = null;

        public static GestorProgramas Instancia
        {
            get
            {
                if (instancia == null)
                    instancia = new GestorProgramas();
                return instancia;
            }
        }
        #endregion

        private Archivo editorTexto = null;
        private Archivo visualizadorImagenes = null;
        private Archivo exploradorArchivos = null;
        private Archivo juego = null;

        private string dirEditorTexto = GestorMemoria.DireccionProgramas + "/" + "Editor de Texto";
        private string dirVisualizadorImagenes = GestorMemoria.DireccionProgramas + "/" + "Visualizador de Imágenes";
        private string dirExploradorArchivos = GestorMemoria.DireccionProgramas + "/" + "Explorador de Archivos";
        private string dirJuego = GestorMemoria.DireccionProgramas + "/" + "Juego";

        private GestorMemoria gestorMemoria = GestorMemoria.Instancia;

        private GestorProgramas()
        {
            editorTexto = new Archivo("Editor de Texto", false, GestorMemoria.DireccionProgramas, "Sistema", Archivo.Ejecutable.EditorTexto, TipoArchivo.Ejecutable);
            visualizadorImagenes = new Archivo("Visualizador de Imágenes", false, GestorMemoria.DireccionProgramas, "Sistema", Archivo.Ejecutable.VisualizadorImagen, TipoArchivo.Ejecutable);
            exploradorArchivos = new Archivo("Explorador de Archivos", false, GestorMemoria.DireccionProgramas, "Sistema", Archivo.Ejecutable.Explorador, TipoArchivo.Ejecutable);
            juego = new Archivo("Juego", false, GestorMemoria.DireccionProgramas, "Sistema", Archivo.Ejecutable.Juego, TipoArchivo.Ejecutable);

            GestorMemoria.Instancia.CrearArchivo(editorTexto);
            GestorMemoria.Instancia.CrearArchivo(visualizadorImagenes);
            GestorMemoria.Instancia.CrearArchivo(exploradorArchivos);
            GestorMemoria.Instancia.CrearArchivo(juego);

        }

        public Archivo EditorTexto
        {
            get
            {
                if(editorTexto == null)
                {
                    editorTexto = gestorMemoria.ObtenerArchivo(dirEditorTexto);
                }
                return editorTexto;
            }
        }

        public Archivo VisualizadorImagenes
        {
            get
            {
                if (visualizadorImagenes == null)
                {
                    visualizadorImagenes = gestorMemoria.ObtenerArchivo(dirVisualizadorImagenes);
                }
                return visualizadorImagenes;
            }
        }

        public Archivo ExploradorArchivos
        {
            get
            {
                if(exploradorArchivos == null)
                {
                    exploradorArchivos = gestorMemoria.ObtenerArchivo(dirExploradorArchivos);
                }
                return exploradorArchivos;
            }
        }

        public Archivo Juego
        {
            get
            {
                if(juego == null)
                {
                    juego = gestorMemoria.ObtenerArchivo(dirJuego);
                }
                return juego;
            }
        }
    }
}
