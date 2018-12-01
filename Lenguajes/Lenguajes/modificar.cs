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
    public partial class modificar_usuario : Form
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = XE; PASSWORD = ORACLE; USER ID=Lenguajes;");

        public modificar_usuario()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ora.Open();
            OracleCommand actualiza = new OracleCommand("modi_clientes", ora);
            actualiza.CommandType = System.Data.CommandType.StoredProcedure;
            actualiza.Parameters.Add("clienteid", OracleType.Number).Value = Convert.ToInt32(tbId.Text);
            actualiza.Parameters.Add("nombreCli", OracleType.VarChar).Value = tbNombre.Text;
            actualiza.Parameters.Add("apellidoCli", OracleType.VarChar).Value = tbApellido.Text;

            actualiza.ExecuteNonQuery();

            MessageBox.Show("listo");
            ora.Close();
            }
      
        }
    }

