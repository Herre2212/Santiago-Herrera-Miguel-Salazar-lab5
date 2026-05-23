using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santiago_Herrera__Miguel_Salazar_LAB_05
{
    public partial class Cotizacion : Form
    {
        public Cotizacion()
        {
            InitializeComponent();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            clServicios.Text = "Amarillo, azul";

        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            
            this.Close();
            Form1 form1 = (Form1)Application.OpenForms["Form1"];
        }
    }
}
