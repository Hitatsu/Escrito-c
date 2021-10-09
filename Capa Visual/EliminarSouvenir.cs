using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;

namespace Capa_Visual
{
    public partial class EliminarSouvenir : Form
    {
        public EliminarSouvenir()
        {
            InitializeComponent();
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            SouvenirController.BajaSouvenir(Nombre.Text);

            MessageBox.Show("Souvenir eliminado");

            this.Close();
        }
    }
}
