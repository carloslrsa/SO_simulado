namespace SistemasOperativos.Programas.Interfaces
{
    partial class ArchivoInterfaz
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.archivoIcono = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.archivoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.archivoIcono)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // archivoIcono
            // 
            this.archivoIcono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.archivoIcono.Image = global::SistemasOperativos.Properties.Resources.archivo;
            this.archivoIcono.Location = new System.Drawing.Point(40, 20);
            this.archivoIcono.Name = "archivoIcono";
            this.archivoIcono.Size = new System.Drawing.Size(100, 100);
            this.archivoIcono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.archivoIcono.TabIndex = 0;
            this.archivoIcono.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.archivoIcono, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.archivoLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Enabled = false;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(180, 200);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // archivoLabel
            // 
            this.archivoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.archivoLabel.AutoSize = true;
            this.archivoLabel.Location = new System.Drawing.Point(55, 157);
            this.archivoLabel.Name = "archivoLabel";
            this.archivoLabel.Size = new System.Drawing.Size(70, 25);
            this.archivoLabel.TabIndex = 1;
            this.archivoLabel.Text = "label1";
            // 
            // ArchivoInterfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ArchivoInterfaz";
            this.Size = new System.Drawing.Size(180, 200);
            ((System.ComponentModel.ISupportInitialize)(this.archivoIcono)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox archivoIcono;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label archivoLabel;
    }
}
