using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenguajes
{
    public partial class EstadoCuenta : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = XE; PASSWORD = ORACLE; USER ID=Lenguajes;");
        public EstadoCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            ora.Open();
            OracleCommand mostrar = new OracleCommand("ver_estado", ora);
            mostrar.CommandType = System.Data.CommandType.StoredProcedure;
            mostrar.Parameters.Add("registros", OracleType.Cursor).Direction = ParameterDirection.Output;
            mostrar.Parameters.Add("cuenta", OracleType.Number).Value = Convert.ToInt32(tbEstado.Text);
            OracleDataAdapter adaptador = new OracleDataAdapter();
            adaptador.SelectCommand = mostrar;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            DgvEstado.DataSource = tabla;
            }
            catch (Exception aviso )
            {
                MessageBox.Show("Error", aviso.ToString());
            }
            ora.Close();
        }
    }
}
