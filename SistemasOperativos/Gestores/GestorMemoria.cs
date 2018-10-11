using SistemasOperativos.Estructuras;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace SistemasOperativos.Gestores
{
    public class GestorMemoria
    {
        private static string DireccionMemoria = "Memoria";
        public static string DireccionBase = "C";

        public static string DireccionProgramas = DireccionBase + "/Programas";
        public static string DireccionArchivos = DireccionBase + "/Usuario";

        private static string DireccionBaseInterna = DireccionMemoria + "/" + DireccionBase;
        private static string DireccionProgramasInterna = DireccionMemoria + "/" + DireccionProgramas;
        private static string DireccionArchivosInterna = DireccionMemoria + "/" + DireccionArchivos;



        private IFormatter formatter = new BinaryFormatter();

        private NodoDirectorio directorios = null;

        #region Singleton
        private static GestorMemoria instancia = null;

        public static GestorMemoria Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new GestorMemoria();
                }
                return instancia;
            }
        }
        #endregion
 
        private GestorMemoria()
        {
            if (!Directory.Exists(DireccionMemoria))
            {
                Directory.CreateDirectory(DireccionMemoria);
            }
            if (!Directory.Exists(DireccionBaseInterna))
            {
                Directory.CreateDirectory(DireccionBaseInterna);

                Archivo directorioProgramasConf = new Archivo("Programas", false, DireccionBase, "Sistema", DireccionProgramas, TipoArchivo.Directorio);
                Archivo directorioArchivosConf = new Archivo("Usuario", false, DireccionBase, "Sistema", DireccionArchivos, TipoArchivo.Directorio);

                CrearArchivo(directorioProgramasConf);
                CrearArchivo(directorioArchivosConf);
            }

            generarArbolDirectorios();
        }

        #region archivos
        private void generarArbolDirectorios()
        {
            directorios = new NodoDirectorio { Nombre = "C" };
            obtenerDirectorios(DireccionBaseInterna, directorios);
        }

        private void obtenerDirectorios(string dir, NodoDirectorio nodo)
        {
            foreach (var s in Directory.GetDirectories(dir))
            {
                DirectoryInfo d = new DirectoryInfo(s);
                NodoDirectorio hijo = new NodoDirectorio { Nombre = d.Name };

                nodo.Nodos.Add(hijo);

                obtenerDirectorios(s, hijo);
            }
        }

        public bool CrearArchivo(Archivo archivo)
        {
            if (Directory.Exists(DireccionMemoria + "/" + archivo.Direccion))
            {
                string nombreTotal = DireccionMemoria + "/" + archivo.Direccion + "/" + archivo.Nombre;
                if (!File.Exists(nombreTotal + ".txt"))
                {
                    Stream stream = new FileStream(nombreTotal + ".txt", FileMode.Create, FileAccess.Write);

                    formatter.Serialize(stream, archivo);
                    stream.Close();

                    if(archivo.Tipo == TipoArchivo.Directorio)
                    {
                        Directory.CreateDirectory(nombreTotal);
                    }
                }
                else
                {
                    return false;
                }

            }
            return false;
        }

        public bool ModificarArchivo(Archivo archivo)
        {
            if (Directory.Exists(DireccionMemoria + "/" + archivo.Direccion))
            {
                string nombreTotal = DireccionMemoria + "/" + archivo.Direccion + "/" + archivo.Nombre + ".txt";
                if (File.Exists(nombreTotal))
                {
                    Stream stream = new FileStream(nombreTotal, FileMode.Create, FileAccess.Write);

                    formatter.Serialize(stream, archivo);
                    stream.Close();
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public Archivo ObtenerArchivo(string dir)
        {
            string dirInterna = DireccionMemoria + "/" + dir;

            if (File.Exists(dirInterna))
            {
                Stream stream = new FileStream(dirInterna, FileMode.Open, FileAccess.Read);

                Archivo ret = (Archivo)formatter.Deserialize(stream);

                stream.Close();

                return ret;
            }
            else
            {
                return null;
            }       
        }

        public bool EliminarArchivo(Archivo archivo)
        {
            string dirInterna = DireccionMemoria + "/" + archivo.Direccion + "/" + archivo.Nombre + ".txt";

            if (File.Exists(dirInterna))
            {
                File.Delete(dirInterna);
                archivo = null;

                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Archivo> ObtenerArchivos(string dir)
        {
            string dirInterna = DireccionMemoria + "/" + dir;

            if (Directory.Exists(dirInterna))
            {
                List<Archivo> ret = new List<Archivo>();

                foreach (var s in Directory.GetFiles(dirInterna))
                {
                    FileInfo f = new FileInfo(s);
                    ret.Add(ObtenerArchivo(dir + "/" + f.Name));
                }

                return ret;
            }
            else
            {
                return null;
            }
        }

        public NodoDirectorio Directorios
        {
            get
            {
                if (directorios == null)
                    generarArbolDirectorios();
                return directorios;
            }
        }
        #endregion

        public bool CrearUsuario(Usuario usuario)
        {
            if (Directory.Exists(DireccionArchivosInterna))
            {
                string nombreTotal = DireccionArchivosInterna + "/" + usuario.Nombre;
                if (!File.Exists(nombreTotal + ".txt"))
                {
                    Stream stream = new FileStream(nombreTotal + ".txt", FileMode.Create, FileAccess.Write);

                    formatter.Serialize(stream, usuario);
                    stream.Close();

                    Directory.CreateDirectory(nombreTotal);
                }
                else
                {
                    return false;
                }

            }
            return false;
        }

    }


    public class NodoDirectorio
    {
        public string Nombre;
        public List<NodoDirectorio> Nodos = new List<NodoDirectorio>();
    }
}
