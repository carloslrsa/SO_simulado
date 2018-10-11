using SistemasOperativos.Programas.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasOperativos.Programas.Interfaces
{
    public partial class EditorTextoInterfaz : ProcesoInterfaz
    {
        public EditorTextoInterfaz(Proceso proceso) : base(proceso)
        {
            botonGuardar.Click += BotonGuardar_Click;
        }

        private void BotonGuardar_Click(object sender, EventArgs e)
        {
            ((EditorTextoProceso)proceso).Guardar(contenidoTexto.Text, direccionTexto.Text , nombreTexto.Text);
        }
    }
}
