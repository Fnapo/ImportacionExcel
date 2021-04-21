
namespace ImportacionExcel.Crear
{
    partial class AsociarPrimaria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grillAsociaciones = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.botonAsociar = new System.Windows.Forms.Button();
            this.comboMysql = new System.Windows.Forms.ComboBox();
            this.labelMysql = new System.Windows.Forms.Label();
            this.labelExcel = new System.Windows.Forms.Label();
            this.comboExcel = new System.Windows.Forms.ComboBox();
            this.Excel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mysql = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillAsociaciones)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(82, 248);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(81, 112);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(81, 12);
            // 
            // grillAsociaciones
            // 
            this.grillAsociaciones.AllowUserToAddRows = false;
            this.grillAsociaciones.AllowUserToDeleteRows = false;
            this.grillAsociaciones.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grillAsociaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grillAsociaciones.ColumnHeadersHeight = 50;
            this.grillAsociaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grillAsociaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excel,
            this.Mysql});
            this.grillAsociaciones.Location = new System.Drawing.Point(82, 348);
            this.grillAsociaciones.MultiSelect = false;
            this.grillAsociaciones.Name = "grillAsociaciones";
            this.grillAsociaciones.ReadOnly = true;
            this.grillAsociaciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grillAsociaciones.RowTemplate.DividerHeight = 3;
            this.grillAsociaciones.RowTemplate.Height = 40;
            this.grillAsociaciones.RowTemplate.ReadOnly = true;
            this.grillAsociaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grillAsociaciones.Size = new System.Drawing.Size(529, 150);
            this.grillAsociaciones.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.botonAsociar);
            this.groupBox4.Controls.Add(this.comboMysql);
            this.groupBox4.Controls.Add(this.labelMysql);
            this.groupBox4.Controls.Add(this.labelExcel);
            this.groupBox4.Controls.Add(this.comboExcel);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(82, 508);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(664, 101);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Asociando Campos";
            // 
            // botonAsociar
            // 
            this.botonAsociar.BackColor = System.Drawing.Color.Gray;
            this.botonAsociar.ForeColor = System.Drawing.Color.White;
            this.botonAsociar.Location = new System.Drawing.Point(566, 57);
            this.botonAsociar.Name = "botonAsociar";
            this.botonAsociar.Size = new System.Drawing.Size(76, 28);
            this.botonAsociar.TabIndex = 4;
            this.botonAsociar.Text = "Asociar";
            this.botonAsociar.UseVisualStyleBackColor = false;
            // 
            // comboMysql
            // 
            this.comboMysql.FormattingEnabled = true;
            this.comboMysql.Location = new System.Drawing.Point(337, 57);
            this.comboMysql.Name = "comboMysql";
            this.comboMysql.Size = new System.Drawing.Size(216, 29);
            this.comboMysql.TabIndex = 3;
            // 
            // labelMysql
            // 
            this.labelMysql.Location = new System.Drawing.Point(338, 25);
            this.labelMysql.Name = "labelMysql";
            this.labelMysql.Size = new System.Drawing.Size(216, 23);
            this.labelMysql.TabIndex = 2;
            this.labelMysql.Text = "Campo MySQL";
            this.labelMysql.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelExcel
            // 
            this.labelExcel.Location = new System.Drawing.Point(19, 31);
            this.labelExcel.Name = "labelExcel";
            this.labelExcel.Size = new System.Drawing.Size(306, 23);
            this.labelExcel.TabIndex = 1;
            this.labelExcel.Text = "Campo Excel";
            this.labelExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboExcel
            // 
            this.comboExcel.FormattingEnabled = true;
            this.comboExcel.Location = new System.Drawing.Point(18, 57);
            this.comboExcel.Name = "comboExcel";
            this.comboExcel.Size = new System.Drawing.Size(306, 29);
            this.comboExcel.TabIndex = 0;
            // 
            // Excel
            // 
            this.Excel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Excel.HeaderText = "Campo Excel";
            this.Excel.MaxInputLength = 255;
            this.Excel.Name = "Excel";
            this.Excel.ReadOnly = true;
            this.Excel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Mysql
            // 
            this.Mysql.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Mysql.HeaderText = "Campo MySQL";
            this.Mysql.MaxInputLength = 255;
            this.Mysql.Name = "Mysql";
            this.Mysql.ReadOnly = true;
            this.Mysql.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AsociarPrimaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grillAsociaciones);
            this.Name = "AsociarPrimaria";
            this.Text = "AsociarPrimaria";
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.grillAsociaciones, 0);
            this.Controls.SetChildIndex(this.groupBox4, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillAsociaciones)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grillAsociaciones;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelExcel;
        private System.Windows.Forms.ComboBox comboExcel;
        private System.Windows.Forms.Button botonAsociar;
        private System.Windows.Forms.ComboBox comboMysql;
        private System.Windows.Forms.Label labelMysql;
        private System.Windows.Forms.DataGridViewTextBoxColumn Excel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mysql;
    }
}