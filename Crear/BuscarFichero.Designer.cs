
namespace ImportacionExcel.Crear
{
    partial class BuscarFichero
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cajaTexto = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.cajaFichero = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cajaTexto);
            this.groupBox1.Controls.Add(this.botonBuscar);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(68, 180);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fichero Base";
            // 
            // cajaTexto
            // 
            this.cajaTexto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.cajaTexto.Location = new System.Drawing.Point(35, 38);
            this.cajaTexto.Name = "cajaTexto";
            this.cajaTexto.PlaceholderText = "Buscando un Fichero";
            this.cajaTexto.ReadOnly = true;
            this.cajaTexto.Size = new System.Drawing.Size(495, 29);
            this.cajaTexto.TabIndex = 2;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBuscar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botonBuscar.Location = new System.Drawing.Point(549, 30);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(94, 45);
            this.botonBuscar.TabIndex = 1;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.BotonBuscar_Click);
            // 
            // cajaFichero
            // 
            this.cajaFichero.Filter = "Archivos Excel | *.xls; *.xlsx";
            // 
            // BuscarFichero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "BuscarFichero";
            this.Text = "Buscandor de Ficheros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.GroupBox groupBox1;
        protected System.Windows.Forms.TextBox cajaTexto;
        protected System.Windows.Forms.Button botonBuscar;
        protected System.Windows.Forms.OpenFileDialog cajaFichero;
    }
}