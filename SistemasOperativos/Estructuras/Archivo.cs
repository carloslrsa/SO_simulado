using SistemasOperativos.Programas.Interfaces;
using SistemasOperativos.Programas.Procesos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasOperativos.Estructuras
{
    [System.Serializable]
    public class Archivo
    {
        protected int direccionMemoria;
        protected string nombre;
        protected bool protegido;
        protected string direccion;
        protected string usuario;
        protected string contenido;
        protected TipoArchivo tipo;


        public Archivo(string nombre, bool protegido, string direccion, string usuario, string contenido, TipoArchivo tipo)
        {
            this.nombre = nombre;
            this.protegido = protegido;
            this.direccion = direccion;
            this.usuario = usuario;
            this.contenido = contenido;
            this.tipo = tipo;
        }

        public virtual Proceso Abrir(object sender = null)
        {

            switch (tipo)
            {
                case TipoArchivo.Archivo:
                    {
                        //Nada
                        return null;
                    }
                case TipoArchivo.Texto:
                    {
                        EditorTextoProceso nuevo = new EditorTextoProceso(this);
                        return nuevo;
                    }
                case TipoArchivo.Imagen:
                    {
                        return null;
                    }
                case TipoArchivo.Directorio:
                    {
                        ExploradorInterfaz i = (ExploradorInterfaz)sender;
                        i.MostrarArchivos(contenido);
                        return null;
                    }
                case TipoArchivo.Ejecutable:
                    {
                        if (contenido == Ejecutable.EditorTexto)
                        {
                            EditorTextoProceso nuevo = new EditorTextoProceso();
                            return nuevo;
                        }
                        else if (contenido == Ejecutable.VisualizadorImagen)
                        {
                            return null;
                        }
                        else if (contenido == Ejecutable.Juego)
                        {
                            return null;
                        }
                        else if (contenido == Ejecutable.Explorador)
                        {
                            ExploradorProceso nuevo = new ExploradorProceso();

                            /*if(sender != null)
                                if(sender is InterfazInicio)
                                    ((InterfazInicio)sender).AgregarVentanaProceso(nuevo.Ventana);*/
                            return nuevo;
                        }
                        else
                        {
                            return null;
                        }
                    }
            }

            return null;
        }


        public string Nombre
        {
            get
            {
                return nombre;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }
        }

        public string Contenido
        {
            get
            {
                return contenido;
            }
            set
            {
                contenido = value ;
            }
        }

        public TipoArchivo Tipo
        {
            get
            {
                return tipo;
            }
        }


        public static class Ejecutable
        {
            public static string EditorTexto = "TextEditor", VisualizadorImagen = "ImageViewer", Juego = "Game", Explorador = "Explorer";
        }

    }
    [System.Serializable]
    public enum TipoArchivo { Archivo, Texto, Imagen, Directorio, Ejecutable }
}
