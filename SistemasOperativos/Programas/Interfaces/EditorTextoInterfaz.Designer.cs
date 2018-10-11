using System.Windows.Forms;

namespace SistemasOperativos.Programas.Interfaces
{
    partial class EditorTextoInterfaz
    {

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        public override void InitializeComponent()
        {
            base.InitializeComponent();

            contenidoTexto = new TextBox();
            direccionTexto = new TextBox();
            nombreTexto = new TextBox();
            botonGuardar = new Button();

            contenedorPanel.Controls.Add(contenidoTexto);
            contenedorPanel.Controls.Add(botonGuardar);
            contenedorPanel.Controls.Add(direccionTexto);
            contenedorPanel.Controls.Add(nombreTexto);

            this.direccionTexto.Location = new System.Drawing.Point(150, 509);
            this.direccionTexto.Name = "direccionTexto";
            this.direccionTexto.Size = new System.Drawing.Size(520, 31);
            this.direccionTexto.BringToFront();

            this.nombreTexto.Location = new System.Drawing.Point(30, 509);
            this.nombreTexto.Name = "direccionTexto";
            this.nombreTexto.Size = new System.Drawing.Size(100, 31);
            this.nombreTexto.BringToFront();

            // 
            // cuadroTexto
            // 
            this.contenidoTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenidoTexto.Location = new System.Drawing.Point(0, 0);
            this.contenidoTexto.Multiline = true;

            this.contenidoTexto.Size = new System.Drawing.Size(796, 559);
            this.contenidoTexto.TabIndex = 0;

            //
            // BotonGuardar
            //
            this.botonGuardar.BackColor = System.Drawing.Color.RoyalBlue;
            this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonGuardar.Location = new System.Drawing.Point(697, 509);

            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 1;
            this.botonGuardar.Text = "Guardar";
            this.botonGuardar.UseVisualStyleBackColor = false;
            this.botonGuardar.BringToFront();
        }

        public TextBox contenidoTexto;
        public TextBox direccionTexto;
        public TextBox nombreTexto;
        Button botonGuardar;

    }
}
