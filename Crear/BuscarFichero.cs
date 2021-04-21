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
        protected static Color fondoActivo = Color.SteelBlue;
        protected static Color fondoDesactivo = Color.Gray;

        public BuscarFichero()
        {
            InitializeComponent();
            botonBuscar.BackColor = fondoActivo;
            botonBuscar.ForeColor = Color.White;
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
                botonBuscar.BackColor = fondoDesactivo;
                botonBuscar.Enabled = false;
            }
            else
            {
                _ = MessageBox.Show("Error o cancelación al buscar un fichero ....");
            }
        }
    }
}
