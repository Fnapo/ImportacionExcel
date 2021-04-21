
namespace ImportacionExcel.Crear
{
    partial class FicheroNombre
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.inputNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(58, 38);
            // 
            // labelNombre
            // 
            this.labelNombre.BackColor = System.Drawing.Color.Goldenrod;
            this.labelNombre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(35, 19);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(608, 42);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre de la Importación\r\n";
            this.labelNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelNombre.Click += new System.EventHandler(this.LabelNombre_Click);
            // 
            // inputNombre
            // 
            this.inputNombre.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNombre.Location = new System.Drawing.Point(35, 79);
            this.inputNombre.MaxLength = 25;
            this.inputNombre.Name = "inputNombre";
            this.inputNombre.PlaceholderText = "Nombre sin espacios";
            this.inputNombre.Size = new System.Drawing.Size(608, 35);
            this.inputNombre.TabIndex = 3;
            this.inputNombre.TextChanged += new System.EventHandler(this.InputNombre_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputNombre);
            this.groupBox2.Controls.Add(this.labelNombre);
            this.groupBox2.Location = new System.Drawing.Point(58, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 126);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // FicheroNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Name = "FicheroNombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FicheroNombre";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label labelNombre;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.TextBox inputNombre;
    }
}