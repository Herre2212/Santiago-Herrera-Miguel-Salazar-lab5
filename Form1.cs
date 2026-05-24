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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Santiago Herrera & Miguel Salazar - LAB 05";
        }

        

        private void rbSedan_CheckedChanged(object sender, EventArgs e)
        {
            pbSedan.Visible = true;
            pbSUV.Visible = false;
            pbPickUp.Visible = false;
        }

        private void rbSUV_CheckedChanged(object sender, EventArgs e)
        {
            pbSUV.Visible = true;
            pbSedan.Visible = false;
            pbPickUp.Visible = false;
        }

        private void rbPickUp_CheckedChanged(object sender, EventArgs e)
        {
            pbPickUp.Visible = true;
            pbSedan.Visible = false;
            pbSUV.Visible = false;
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            rbPickUp.Checked = false;
            rbSUV.Checked = false;
            rbSedan.Checked = false;

            cbAromatizante.Checked = false;
            cbAspirado.Checked = false;
            cbEncerado.Checked = false;
            cbMotor.Checked = false;

            pbPickUp.Visible = false;
            pbSedan.Visible = false;
            pbSUV.Visible = false;
        }

        private void btCotizacion_Click(object sender, EventArgs e)
        {
            string tipoVehiculo = "";

            if (rbSedan.Checked)
            {
                tipoVehiculo = "Sedán";
            }
            else if (rbSUV.Checked)
            {
                tipoVehiculo = "SUV";
            }
            else if (rbPickUp.Checked)
            {
                tipoVehiculo = "Pick-up";
            }

            Precios precios = new Precios(tipoVehiculo, cbAspirado.Checked, cbEncerado.Checked, cbMotor.Checked, cbAromatizante.Checked);

            Cotizacion cotizacion = new Cotizacion(precios);
            cotizacion.Show();
            this.Hide();

            cotizacion.FormClosed += (s, args) => this.Show();
        }
    }
}
