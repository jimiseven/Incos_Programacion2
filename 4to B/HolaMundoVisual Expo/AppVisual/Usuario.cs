using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppVisual
{
    class Usuario
    {
        public int idUsuario;
        public string nombreUsuario;
        public int numeroCelularUsuario;

        public Usuario(int idUsuario, string nombreUsuario, int numeroCelularUsuario)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.numeroCelularUsuario = numeroCelularUsuario;
        }

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        public string NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public int NumeroCelularUsuario
        {
            get { return numeroCelularUsuario; }
            set { numeroCelularUsuario = value; }
        }

        public void VisualizarUsuario()
        {
            Console.WriteLine("Estos son los datos del Usuario: ");
            Console.WriteLine("id del Usuario : " + idUsuario);
            Console.WriteLine("Nombre del Usuario : " + nombreUsuario);
            Console.WriteLine("numero de celular del Usuario : " + numeroCelularUsuario);

        }


    }
}
