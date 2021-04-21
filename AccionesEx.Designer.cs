
namespace ImportacionExcel
{
    partial class AccionesEx
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
            this.botonEjecutar = new System.Windows.Forms.Button();
            this.botonCrearActualizar = new System.Windows.Forms.Button();
            this.botonActualizar = new System.Windows.Forms.Button();
            this.botonBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonEjecutar
            // 
            this.botonEjecutar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.botonEjecutar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonEjecutar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonEjecutar.Location = new System.Drawing.Point(162, 38);
            this.botonEjecutar.Name = "botonEjecutar";
            this.botonEjecutar.Size = new System.Drawing.Size(417, 89);
            this.botonEjecutar.TabIndex = 0;
            this.botonEjecutar.Text = "Ejecutar una Importación";
            this.botonEjecutar.UseVisualStyleBackColor = false;
            // 
            // botonCrearActualizar
            // 
            this.botonCrearActualizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.botonCrearActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonCrearActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonCrearActualizar.Location = new System.Drawing.Point(162, 164);
            this.botonCrearActualizar.Name = "botonCrearActualizar";
            this.botonCrearActualizar.Size = new System.Drawing.Size(417, 89);
            this.botonCrearActualizar.TabIndex = 1;
            this.botonCrearActualizar.Text = "Crear una Importación";
            this.botonCrearActualizar.UseVisualStyleBackColor = false;
            this.botonCrearActualizar.Click += new System.EventHandler(this.BotonCrearActualizar_Click);
            // 
            // botonActualizar
            // 
            this.botonActualizar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.botonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonActualizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonActualizar.Location = new System.Drawing.Point(162, 290);
            this.botonActualizar.Name = "botonActualizar";
            this.botonActualizar.Size = new System.Drawing.Size(417, 89);
            this.botonActualizar.TabIndex = 3;
            this.botonActualizar.Text = "Actualizar una Importación";
            this.botonActualizar.UseVisualStyleBackColor = false;
            // 
            // botonBorrar
            // 
            this.botonBorrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.botonBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botonBorrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonBorrar.Location = new System.Drawing.Point(162, 416);
            this.botonBorrar.Name = "botonBorrar";
            this.botonBorrar.Size = new System.Drawing.Size(417, 89);
            this.botonBorrar.TabIndex = 4;
            this.botonBorrar.Text = "Borrar una Importación";
            this.botonBorrar.UseVisualStyleBackColor = false;
            // 
            // AccionesEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.botonBorrar);
            this.Controls.Add(this.botonActualizar);
            this.Controls.Add(this.botonCrearActualizar);
            this.Controls.Add(this.botonEjecutar);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximizeBox = false;
            this.Name = "AccionesEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acciones a Realizar";
            this.Load += new System.EventHandler(this.AccionesEx_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonEjecutar;
        private System.Windows.Forms.Button botonCrearActualizar;
        private System.Windows.Forms.Button botonActualizar;
        private System.Windows.Forms.Button botonBorrar;
    }
}