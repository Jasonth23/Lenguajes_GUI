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
    public partial class tipoCuenta : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = XE; PASSWORD = ORACLE; USER ID=Lenguajes;");

        public tipoCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ora.Open();
            try
            {
                OracleCommand actualiza = new OracleCommand("modi_limite", ora);
                actualiza.CommandType = System.Data.CommandType.StoredProcedure;
                actualiza.Parameters.Add("id_tipo", OracleType.Number).Value = Convert.ToInt32(tbId_tipo.Text);
                actualiza.Parameters.Add("cambio_limit", OracleType.Float).Value = Convert.ToDouble(tbLimite_new.Text);
                actualiza.ExecuteNonQuery();

                MessageBox.Show("listo");
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
            ora.Close();
        }
    }
}
