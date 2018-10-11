using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasOperativos.Estructuras;

namespace SistemasOperativos.Programas.Interfaces
{
    public partial class ArchivoInterfaz : UserControl
    {
        public Archivo archivo;

        public ArchivoInterfaz(Archivo archivo)
        {
            this.archivo = archivo;

            InitializeComponent();

            archivoLabel.Text = archivo.Nombre;

            switch (archivo.Tipo)
            {
                case TipoArchivo.Archivo:
                    {
                        archivoIcono.Image = Properties.Resources.archivo;
                        break;
                    }
                case TipoArchivo.Directorio:
                    {
                        archivoIcono.Image = Properties.Resources.carpeta;
                        break;
                    }
                case TipoArchivo.Ejecutable:
                    {
                        break;
                    }
                case TipoArchivo.Imagen:
                    {
                        archivoIcono.Image = Properties.Resources.imagen;
                        break;
                    }
                case TipoArchivo.Texto:
                    {
                        archivoIcono.Image = Properties.Resources.texto;
                        break;
                    }
            }
        }
    }
}
