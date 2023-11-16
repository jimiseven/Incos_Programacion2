using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVisual
{
    class Venta
    {
        public int idVenta;
        public int numeroCelularVenta;
        public int costo;
        public string nombreVenta;
        private string servicio;
        public DateTime fechaInicio;
        public DateTime fechaFin;

        public Venta(int idVenta, int numeroCelularVenta, int costo, string nombreVenta, string servicio, DateTime fechaInicio, DateTime fechaFin)
        {
            this.idVenta = idVenta;
            this.numeroCelularVenta = numeroCelularVenta;
            this.costo = costo;
            this.nombreVenta = nombreVenta;
            this.servicio = servicio;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }


        public int IdVenta
        {
            get { return idVenta; }
            set { idVenta = value; }
        }

        public int NumeroCelularVenta
        {
            get { return numeroCelularVenta; }
            set { numeroCelularVenta = value; }
        }

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }

        public string NombreVenta
        {
            get { return nombreVenta; }
            set { nombreVenta = value; }
        }

        public string Servicio
        {
            get { return servicio; }
            set { servicio = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public int Dias
        {
            get
            {
                return (DateTime.Now - this.fechaFin).Days;
            }
        }


        public void VisualizarVenta()
        {
            Console.WriteLine("Estos son los datos de la Venta: ");
            Console.WriteLine("id de la venta : " + idVenta);
            Console.WriteLine("numero de celular de la Venta : " + numeroCelularVenta);
            Console.WriteLine("numero de celular de la Venta : " + costo);
            Console.WriteLine("nombre de la venta : " + nombreVenta);
            Console.WriteLine("fecha inicio  : " + fechaInicio);
            Console.WriteLine("fecha fin : " + fechaFin);

        }

    }
}
