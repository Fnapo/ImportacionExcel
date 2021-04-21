using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ImportacionExcel.Crear
{
    public partial class ElegirModelo : FicheroNombre
    {
        public ElegirModelo()
        {
            InitializeComponent();
            DesActivarTrasBBDD();
            CambiarColorBotones();
        }


        virtual protected void DesActivarTrasBBDD()
        {
            BotonTabla.Enabled = BotonBBDD.Enabled = ComboTabla.Enabled = false;
        }

        virtual protected void CambiarColorBotones()
        {
            BotonBBDD.BackColor = (BotonBBDD.Enabled ? fondoActivo : fondoDesactivo);
            BotonTabla.BackColor = (BotonTabla.Enabled ? fondoActivo : fondoDesactivo);
        }

        protected int ComboTextoActualizar(ComboBox combo)
        {
            int posible = -1;
            string texto = combo.Text.Trim().ToLower(), textoActual;

            if (texto.Length > 0)
            {
                for (int i = 0; i < combo.Items.Count; ++i)
                {
                    textoActual = combo.Items[i].ToString().ToLower();
                    if (textoActual.StartsWith(texto))
                    {
                        posible = i;
                        break;
                    }
                }
            }
            combo.SelectedIndex = posible;

            return posible;
        }
        protected void ComboBBDD_TextUpdate(object sender, EventArgs e)
        {
            int posible = ComboTextoActualizar((ComboBox)sender);

            if(posible == -1)
            {
                DesActivarTrasBBDD();
                CambiarColorBotones();
            }
        }

        protected void ComboBBDD_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesActivarTrasBBDD();
            BotonBBDD.Enabled = ComboBBDD.SelectedIndex >= 0;
            CambiarColorBotones();
        }

        virtual protected void DesActivarTrasTabla()
        {
            BotonTabla.Enabled = false;
            CambiarColorBotones();
        }
        protected void ComboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            DesActivarTrasTabla();
            BotonTabla.Enabled = ComboTabla.SelectedIndex >= 0;
            CambiarColorBotones();
        }

        protected void ComboTabla_TextUpdate(object sender, EventArgs e)
        {
            int posible = ComboTextoActualizar((ComboBox)sender);

            if (posible == -1)
            {
                DesActivarTrasTabla();
                CambiarColorBotones();
            }
        }

        protected void LlenarComboSQL(ComboBox combo, string cadenaConexion, string cadenaConsulta, 
            int campo = 0)
        {
            using MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            try
            {
                MySqlCommand comando = new MySqlCommand(cadenaConsulta, conexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataSet resultado = new DataSet();

                adaptador.Fill(resultado);
                foreach (DataRow fila in resultado.Tables[0].Rows)
                {
                    combo.Items.Add(fila[campo]);
                }
                conexion.Close();
            }
            catch (MySqlException error)
            {
                MessageBox.Show($"Error de Conexión: {cadenaConexion}.\nCon el mensaje: {error.Message}");
                Close();
            }
        }

        private void BotonBBDD_Click(object sender, EventArgs e)
        {
            string cadenaConexion = $"SERVER=localhost;DATABASE={ComboBBDD.Text};UID=root;PASSWORD=",
                cadenaVerTablas = $"SHOW TABLES FROM {ComboBBDD.Text}";
            //cadenaVerCampos = "SHOW FIELDS FROM autores;";

            LlenarComboSQL(ComboTabla, cadenaConexion, cadenaVerTablas);
            ComboBBDD.Enabled = BotonBBDD.Enabled = false;
            ComboTabla.Enabled = true;
            CambiarColorBotones();
        }

        private void BotonTabla_Click(object sender, EventArgs e)
        {
            ComboTabla.Enabled = BotonTabla.Enabled = false;
            CambiarColorBotones();
        }

        private void ComboBBDD_Enter(object sender, EventArgs e)
        {
            if (ComboBBDD.Items.Count == 0)
            {
                string cadenaConexion = "SERVER=localhost;DATABASE=;UID=root;PASSWORD=",
                    cadenaVerBases = "SHOW DATABASES";
                //cadenaVerCampos = "SHOW FIELDS FROM autores;";

                LlenarComboSQL(ComboBBDD, cadenaConexion, cadenaVerBases);
            }
        }
    }
}
