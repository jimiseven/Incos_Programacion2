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
        public string nombreVenta;
        public DateTime fechaInicio;
        public DateTime fechaFin;

        public Venta(int idVenta, int numeroCelularVenta, string nombreVenta, DateTime fechaInicio, DateTime fechaFin)
        {
            this.idVenta = idVenta;
            this.numeroCelularVenta = numeroCelularVenta;
            this.nombreVenta = nombreVenta;
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

        public string NombreVenta
        {
            get { return nombreVenta; }
            set { nombreVenta = value; }
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

        public void VisualizarVenta()
        {
            Console.WriteLine("Estos son los datos de la Venta: ");
            Console.WriteLine("id de la venta : " + idVenta);
            Console.WriteLine("numero de celular de la Venta : " + numeroCelularVenta);
            Console.WriteLine("nombre de la venta : " + nombreVenta);
            Console.WriteLine("fecha inicio  : " + fechaInicio);
            Console.WriteLine("fecha fin : " + fechaFin);

        }

    }
}
