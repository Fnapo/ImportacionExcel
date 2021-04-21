using System;
using System.Text.RegularExpressions;

namespace ImportacionExcel.Crear
{
    public partial class FicheroNombre : BuscarFichero
    {
        public FicheroNombre()
        {
            InitializeComponent();
        }

        private void InputNombre_TextChanged(object sender, EventArgs e)
        {
            string patron = "\\s+", cambio = "", inicial = inputNombre.Text;
            Regex rgx = new Regex(patron);
            string resultado = rgx.Replace(inputNombre.Text, cambio);

            if (inicial != resultado)
            {
                inputNombre.Text = resultado;
                inputNombre.SelectionStart = resultado.Length;
                inputNombre.Focus();
            }
        }

        private void LabelNombre_Click(object sender, EventArgs e)
        {
            inputNombre.SelectionStart = inputNombre.Text.Length;
            inputNombre.Focus();
        }
    }
}
