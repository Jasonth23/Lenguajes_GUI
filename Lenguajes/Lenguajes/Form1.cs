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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OracleConnection ora = new OracleConnection("DATA SOURCE = XE; PASSWORD = ORACLE; USER ID=Lenguajes;");

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            vistas vista = new vistas();
            vista.Show();
          
            

        }

        private void BtnActualizarLimit_Click(object sender, EventArgs e)
        {
            tipoCuenta tipo = new tipoCuenta();
            tipo.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            modificar_usuario usuario_mod = new modificar_usuario();
            usuario_mod.Show();
        }

        private void BtnEstado_Click(object sender, EventArgs e)
        {
            EstadoCuenta estado = new EstadoCuenta();
            estado.Show();
        }
    }
}
