using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ImportacionExcel.Crear
{
    public partial class ImportacionBasica : FicheroNombre
    {
        public ImportacionBasica()
        {
            InitializeComponent();
            AsociarPrimaria.Enabled = false;
            CambiarColorAP();
        }

        private void ComboPrimaria_SelectedIndexChanged(object sender, EventArgs e) 
        {
            AsociarPrimaria.Enabled = ComboPrimaria.SelectedIndex >= 0;
            CambiarColorAP();
        }

        private void ComboPrimaria_TextUpdate(object sender, EventArgs e)
        {
            if (ComboPrimaria.SelectedItem == null)
            {
                AsociarPrimaria.Enabled = false;
            }
            else
            {
                AsociarPrimaria.Enabled = ComboPrimaria.Text == ComboPrimaria.SelectedItem.ToString();
            }
            CambiarColorAP();
        }

        private void CambiarColorAP()
        {
            AsociarPrimaria.BackColor = (AsociarPrimaria.Enabled ? System.Drawing.Color.DodgerBlue 
                : System.Drawing.Color.Gray);
        }

        private void ImportacionBasica_Shown(object sender, EventArgs e)
        {
            string cadenaConexion = "SERVER=localhost;DATABASE=;UID=root;PASSWORD=", // Database en blanco y así ver todas las BBDD
                cadenaVerCampos = "SHOW DATABASES";
                //cadenaVerCampos = "SHOW FIELDS FROM autores;";
            using MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            try
            {
                conexion.Open();
                MessageBox.Show("Conexión correctamente realizada ...");
                conexion.Close();

                MySqlCommand comando = new MySqlCommand(cadenaVerCampos, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataSet resultado = new DataSet();

                ComboPrimaria.Items.AddRange(new object[] {
                    "Batalla",
                    "Zorra",
                    "Opción 11",
                    "Opción 2",
                    "Opción letra"
                });
                adaptador.Fill(resultado);
                foreach (DataRow fila in resultado.Tables[0].Rows)
                {
                    if (fila[3].ToString() == "PRI")
                    {
                        labelPrimaria.Text = fila[0].ToString();
                        break;
                    }
                }
            }
            catch (MySqlException error)
            {
                MessageBox.Show($"Error de Conexión: {cadenaConexion}.\nCon el mensaje: {error.Message}");
                Close();
            }
        }
    }
}
