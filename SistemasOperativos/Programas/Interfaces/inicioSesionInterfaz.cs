using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemasOperativos.Estructuras;
using SistemasOperativos.Gestores;

namespace SistemasOperativos.Programas.Interfaces
{
    public partial class inicioSesionInterfaz : Form
    {
        public inicioSesionInterfaz()
        {
            InitializeComponent();

            List<Usuario> usuarios = GestorMemoria.Instancia.ObtenerUsuarios();

            foreach (var usuario in usuarios)
            {
                cmbUsuario.Items.Add(usuario.Nombre);
            }

            btnRegistrar.Click += BtnRegistrar_Click;

            btnIniciar.Click += BtnIniciar_Click;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (cmbUsuario.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                Usuario usuario = GestorMemoria.Instancia.ObtenerUsuario(cmbUsuario.Text);
                if(usuario == null)
                {
                    MessageBox.Show("No se encontró el usuario");
                }
                else
                {
                    if (usuario.Contrasena.Equals(txtPassword.Text))
                    {
                        Gestorusuarios.Instancia.UsuarioActivo = usuario;

                        new EscritorioInterfaz().Show();
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta");
                    }
                }
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if(cmbUsuario.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                Usuario nuevo = new Usuario(cmbUsuario.Text, txtPassword.Text);
                if (GestorMemoria.Instancia.CrearUsuario(nuevo))
                {
                    MessageBox.Show("Nuevo usuario registrado");
                    cmbUsuario.Items.Add(cmbUsuario.Text);
                }
                else
                {
                    MessageBox.Show("El usuario ya existe");
                }
            }
        }
    }
}
