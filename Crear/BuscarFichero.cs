using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImportacionExcel.Crear
{
    public partial class BuscarFichero : Form
    {
        public BuscarFichero()
        {
            InitializeComponent();
        }

        protected void BotonBuscar_Click(object sender, EventArgs e)
        {
            string nombreFichero;

            cajaFichero.FileName = "";
            cajaFichero.ShowDialog();
            nombreFichero = cajaFichero.FileName;

            if (System.IO.File.Exists(nombreFichero))
            {
                cajaTexto.Text = nombreFichero;
                _ = MessageBox.Show("Fichero encontrado correctamente ....");
            }
            else
            {
                _ = MessageBox.Show("Error o cancelación al buscar un fichero ....");
            }
        }
    }
}
