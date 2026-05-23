using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Santiago_Herrera__Miguel_Salazar_LAB_05
{
    internal class Precios
    {
        private string tipoVehiculo;
        private bool aspirado;
        private bool encerado;
        private bool lavadoMotor;
        private bool aromatizante;

        public Precios(string tipoVehiculo, bool aspirado, bool encerado, bool lavadoMotor, bool aromatizante)
        {
            this.tipoVehiculo = tipoVehiculo;
            this.aspirado = aspirado;
            this.encerado = encerado;
            this.lavadoMotor = lavadoMotor;
            this.aromatizante = aromatizante;
        }

        public double ObtenerPrecioBase()
        {
            double precioBase = 0;

            if (tipoVehiculo.Equals("Sedán"))
            {
                precioBase = 6.00;
            }
            if (tipoVehiculo.Equals("SUV"))
            {
                precioBase = 8.00;
            }
            if (tipoVehiculo.Equals("Pick-up"))
            {
                precioBase = 6.00;
            }

            return precioBase;
        }

        public double ObtenerPrecioAdicionales()
        {
            double total = 0;

            if (aspirado)
            {
                total += 2.00;
            }
            if (encerado)
            {
                total += 4.00;
            }
            if (lavadoMotor)
            {
                total += 5.00;
            }
            if (aromatizante)
            {
                total += 1.50;
            }

            return total;
        }

        public double CalcularTotal()
        {
            return ObtenerPrecioBase() + ObtenerPrecioAdicionales();
        }

        public string ObtenerServiciosTexto()
        {
            List<string> servicios = new List<string>();

            if (aspirado)
            {
                servicios.Add("Aspirado interior");
            }
            if (encerado)
            {
                servicios.Add("Encerado");
            }
            if (lavadoMotor)
            {
                servicios.Add("Lavado de motor");
            }
            if (aromatizante)
            {
                servicios.Add("Aromatizante");
            }


            if (servicios.Count > 0)
                return string.Join(", ", servicios);
            else
                return "Ninguno";
        }
    }
}
