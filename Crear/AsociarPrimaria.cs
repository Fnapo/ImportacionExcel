using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImportacionExcel.Crear
{
    public partial class AsociarPrimaria : ElegirModelo
    {
        public AsociarPrimaria()
        {
            InitializeComponent();
            comboExcel.Enabled = comboMysql.Enabled = botonAsociar.Enabled = false;
        }
    }
}
