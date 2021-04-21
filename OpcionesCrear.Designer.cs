
namespace ImportacionExcel
{
    partial class OpcionesCrear
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
            this.botonCrearBorrado = new System.Windows.Forms.Button();
            this.botonCrearActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonCrearBorrado
            // 
            this.botonCrearBorrado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.botonCrearBorrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCrearBorrado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonCrearBorrado.Location = new System.Drawing.Point(192, 228);
            this.botonCrearBorrado.Name = "botonCrearBorrado";
            this.botonCrearBorrado.Size = new System.Drawing.Size(417, 89);
            this.botonCrearBorrado.TabIndex = 4;
            this.botonCrearBorrado.Text = "Crear una Importación de Borrado";
            this.botonCrearBorrado.UseVisualStyleBackColor = false;
            this.botonCrearBorrado.Click += new System.EventHandler(this.BotonCrearBorrado_Click);
            // 
            // botonCrearActualizar
            // 
            this.botonCrearActualizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.botonCrearActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCrearActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonCrearActualizar.Location = new System.Drawing.Point(192, 133);
            this.botonCrearActualizar.Name = "botonCrearActualizar";
            this.botonCrearActualizar.Size = new System.Drawing.Size(417, 89);
            this.botonCrearActualizar.TabIndex = 3;
            this.botonCrearActualizar.Text = "Crear una Importación de Actualización";
            this.botonCrearActualizar.UseVisualStyleBackColor = false;
            // 
            // OpcionesCrear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonCrearBorrado);
            this.Controls.Add(this.botonCrearActualizar);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "OpcionesCrear";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones de Creación";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonCrearBorrado;
        private System.Windows.Forms.Button botonCrearActualizar;
    }
}