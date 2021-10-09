using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Visual
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarCuenta();
            }
            catch (Exception ex)
            {

                MessageBox.Show("No es valido su ingreso");
            }
        }

        private void ValidarCuenta()
        {
            
        }
    }
}
