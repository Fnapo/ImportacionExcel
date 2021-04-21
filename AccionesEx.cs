using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImportacionExcel
{
    public partial class AccionesEx : Form
    {
        public AccionesEx()
        {
            InitializeComponent();
        }

        private void BotonCrearActualizar_Click(object sender, EventArgs e)
        {
            OpcionesCrear crear = new OpcionesCrear();

            Hide();
            _ = crear.ShowDialog();
            Show();
        }

        private void AccionesEx_Load(object sender, EventArgs e)
        {

        }
    }
}
