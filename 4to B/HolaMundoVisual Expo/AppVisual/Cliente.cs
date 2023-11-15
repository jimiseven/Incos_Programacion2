using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVisual
{
    class Cliente
    {
        public int idCliente;
        public string nombreCliente;
        public int numeroCelularCliente;

        public Cliente(int idCliente, string nombreCliente, int numeroCelularCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.numeroCelularCliente = numeroCelularCliente;
        }


        public int IdCliente
        {
            get { return idCliente; }
            set { idCliente = value; }
        }


        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }


        public int NumeroCelularCliente1
        {
            get { return numeroCelularCliente; }
            set { numeroCelularCliente = value; }
        }

        public void VisualizarCliente()
        {
            Console.WriteLine("Estos son los datos del Cliente son: ");
            Console.WriteLine("id del Cliente : " + idCliente);
            Console.WriteLine("Nombre del Cliente : " + nombreCliente);
            Console.WriteLine("numero de celular del cliente : " + numeroCelularCliente);

        }

    }

    
}
