
namespace ImportacionExcel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lectura = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lectura
            // 
            this.Lectura.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Lectura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lectura.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lectura.Location = new System.Drawing.Point(164, 107);
            this.Lectura.Name = "Lectura";
            this.Lectura.Size = new System.Drawing.Size(430, 137);
            this.Lectura.TabIndex = 0;
            this.Lectura.Text = "Leer Fichero Excel";
            this.Lectura.UseVisualStyleBackColor = false;
            this.Lectura.Click += new System.EventHandler(this.Lectura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lectura);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Lectura;
    }
}

