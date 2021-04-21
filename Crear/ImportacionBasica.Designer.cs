
namespace ImportacionExcel.Crear
{
    partial class ImportacionBasica
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
            this.ComboPrimaria = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AsociarPrimaria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.campoExcel = new System.Windows.Forms.Label();
            this.labelPrimaria = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboPrimaria
            // 
            this.ComboPrimaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboPrimaria.FormattingEnabled = true;
            this.ComboPrimaria.Location = new System.Drawing.Point(35, 74);
            this.ComboPrimaria.Name = "ComboPrimaria";
            this.ComboPrimaria.Size = new System.Drawing.Size(228, 29);
            this.ComboPrimaria.Sorted = true;
            this.ComboPrimaria.TabIndex = 5;
            this.ComboPrimaria.SelectedIndexChanged += new System.EventHandler(this.ComboPrimaria_SelectedIndexChanged);
            this.ComboPrimaria.TextUpdate += new System.EventHandler(this.ComboPrimaria_TextUpdate);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AsociarPrimaria);
            this.groupBox3.Controls.Add(this.ComboPrimaria);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.campoExcel);
            this.groupBox3.Controls.Add(this.labelPrimaria);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(58, 286);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 125);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asociando la Clave Primaria";
            // 
            // AsociarPrimaria
            // 
            this.AsociarPrimaria.BackColor = System.Drawing.Color.DodgerBlue;
            this.AsociarPrimaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AsociarPrimaria.Enabled = false;
            this.AsociarPrimaria.Location = new System.Drawing.Point(543, 35);
            this.AsociarPrimaria.Name = "AsociarPrimaria";
            this.AsociarPrimaria.Size = new System.Drawing.Size(99, 67);
            this.AsociarPrimaria.TabIndex = 6;
            this.AsociarPrimaria.Text = "Asociar";
            this.AsociarPrimaria.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(297, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Campo BBDD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campoExcel
            // 
            this.campoExcel.Location = new System.Drawing.Point(35, 25);
            this.campoExcel.Name = "campoExcel";
            this.campoExcel.Size = new System.Drawing.Size(228, 33);
            this.campoExcel.TabIndex = 2;
            this.campoExcel.Text = "Campo Excel";
            this.campoExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPrimaria
            // 
            this.labelPrimaria.BackColor = System.Drawing.Color.Wheat;
            this.labelPrimaria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrimaria.Location = new System.Drawing.Point(297, 74);
            this.labelPrimaria.Name = "labelPrimaria";
            this.labelPrimaria.Size = new System.Drawing.Size(233, 29);
            this.labelPrimaria.TabIndex = 1;
            this.labelPrimaria.Text = "label1";
            this.labelPrimaria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImportacionBasica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 509);
            this.Controls.Add(this.groupBox3);
            this.Name = "ImportacionBasica";
            this.Text = "ImportacionBasica";
            this.Shown += new System.EventHandler(this.ImportacionBasica_Shown);
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
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label campoExcel;
        protected System.Windows.Forms.Label labelPrimaria;
        private System.Windows.Forms.ComboBox ComboPrimaria;
        private System.Windows.Forms.Button AsociarPrimaria;
    }
}