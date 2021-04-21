using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ImportacionExcel.Crear;

namespace ImportacionExcel
{
    public partial class OpcionesCrear : Form
    {
        public OpcionesCrear()
        {
            InitializeComponent();
        }

        private void BotonCrearBorrado_Click(object sender, EventArgs e)
        {
            //CrearBorrado crear = new CrearBorrado();
            ElegirModelo crear = new ElegirModelo();

            Hide();
            crear.ShowDialog();
            Show();
        }
    }
}
