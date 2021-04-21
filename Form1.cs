using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImportacionExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lectura_Click(object sender, EventArgs e)
        {
            int salida = LectorExcel.Lectura();

            if (salida != 0)
            {
                _ = MessageBox.Show($"Error en la fila {salida} del fichero.", "Error en el fichero.",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                _ = MessageBox.Show("Fichero correctamente leído.", "Fichero correcto.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
