
namespace ImportacionExcel.Crear
{
    partial class ElegirModelo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BotonTabla = new System.Windows.Forms.Button();
            this.ComboTabla = new System.Windows.Forms.ComboBox();
            this.BotonBBDD = new System.Windows.Forms.Button();
            this.ComboBBDD = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BotonTabla);
            this.groupBox3.Controls.Add(this.ComboTabla);
            this.groupBox3.Controls.Add(this.BotonBBDD);
            this.groupBox3.Controls.Add(this.ComboBBDD);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(58, 296);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 90);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Elige la BBDD y la Tabla";
            // 
            // BotonTabla
            // 
            this.BotonTabla.BackColor = System.Drawing.Color.SteelBlue;
            this.BotonTabla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonTabla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonTabla.Location = new System.Drawing.Point(566, 40);
            this.BotonTabla.Name = "BotonTabla";
            this.BotonTabla.Size = new System.Drawing.Size(77, 29);
            this.BotonTabla.TabIndex = 3;
            this.BotonTabla.Text = "Tabla";
            this.BotonTabla.UseVisualStyleBackColor = false;
            this.BotonTabla.Click += new System.EventHandler(this.BotonTabla_Click);
            // 
            // ComboTabla
            // 
            this.ComboTabla.FormattingEnabled = true;
            this.ComboTabla.Location = new System.Drawing.Point(337, 40);
            this.ComboTabla.Name = "ComboTabla";
            this.ComboTabla.Size = new System.Drawing.Size(216, 29);
            this.ComboTabla.TabIndex = 2;
            this.ComboTabla.SelectedIndexChanged += new System.EventHandler(this.ComboTabla_SelectedIndexChanged);
            this.ComboTabla.TextUpdate += new System.EventHandler(this.ComboTabla_TextUpdate);
            // 
            // BotonBBDD
            // 
            this.BotonBBDD.BackColor = System.Drawing.Color.SteelBlue;
            this.BotonBBDD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BotonBBDD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotonBBDD.Location = new System.Drawing.Point(247, 39);
            this.BotonBBDD.Name = "BotonBBDD";
            this.BotonBBDD.Size = new System.Drawing.Size(77, 29);
            this.BotonBBDD.TabIndex = 1;
            this.BotonBBDD.Text = "BBDD";
            this.BotonBBDD.UseVisualStyleBackColor = false;
            this.BotonBBDD.Click += new System.EventHandler(this.BotonBBDD_Click);
            // 
            // ComboBBDD
            // 
            this.ComboBBDD.FormattingEnabled = true;
            this.ComboBBDD.Location = new System.Drawing.Point(18, 39);
            this.ComboBBDD.Name = "ComboBBDD";
            this.ComboBBDD.Size = new System.Drawing.Size(216, 29);
            this.ComboBBDD.TabIndex = 0;
            this.ComboBBDD.SelectedIndexChanged += new System.EventHandler(this.ComboBBDD_SelectedIndexChanged);
            this.ComboBBDD.TextUpdate += new System.EventHandler(this.ComboBBDD_TextUpdate);
            this.ComboBBDD.Enter += new System.EventHandler(this.ComboBBDD_Enter);
            // 
            // ElegirModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Name = "ElegirModelo";
            this.Text = "ElegirModelo";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox3;
        protected System.Windows.Forms.Button BotonTabla;
        protected System.Windows.Forms.ComboBox ComboTabla;
        protected System.Windows.Forms.Button BotonBBDD;
        protected System.Windows.Forms.ComboBox ComboBBDD;
    }
}