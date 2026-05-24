using System;
using System.Windows.Forms;

namespace Santiago_Herrera__Miguel_Salazar_LAB_05
{
    public partial class Cotizacion : Form
    {
        private Precios precios;

        public Cotizacion(Precios precios)
        {
            InitializeComponent();
            this.precios = precios;
        }

        private void Cotizacion_Load(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(precios.TipoVehiculo);

            item.SubItems.Add(precios.ObtenerServiciosTexto());
            item.SubItems.Add(precios.ObtenerPrecioBase().ToString("C2"));
            item.SubItems.Add(precios.CalcularTotal().ToString("C2"));

            listView1.Items.Add(item);
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}