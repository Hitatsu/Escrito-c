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
    public partial class AgregarSouvenir : Form
    {
        public AgregarSouvenir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SouvenirController.AltaSouvenir(int.Parse(Nombre.Text), Nombre.Text, Descripcion.Text, Stock.Text, Precio.Text, FechaDeAlta.Text);

            MessageBox.Show("Fue agregado el souvenir");

            this.Close();
        }
    }
}
