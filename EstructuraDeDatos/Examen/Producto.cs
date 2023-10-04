using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Producto
    {
        public int codProducto;
        public string nombre;
        public string tipo;
        public int precio;
        public string marca;

        public Producto(int codProducto, string nombre, string tipo, int precio, string marca)
        {
            this.codProducto = codProducto;
            this.nombre = nombre;
            this.tipo = tipo;
            this.precio = precio;
            this.marca = marca;
        }

        public void VisualizarProducto()
        {
            Console.WriteLine("Estos son los datos del Producto : ");
            Console.WriteLine("CodProducto : " + codProducto);
            Console.WriteLine("Nombre : " + nombre);
            Console.WriteLine("Tipo : " + tipo);
            Console.WriteLine("Precio : " + precio);
            Console.WriteLine("Marca : " + marca);
            Console.WriteLine("=========================");
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public int CodProducto
        {
            get { return codProducto; }
            set
            {
                if (value >= 100 && value <= 99999999)
                {
                    codProducto = value;
                }
                else
                {
                    codProducto = 0;
                }
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public int Precio
        {
            get { return precio; }
            set
            {
                if (value >= 20 && value <= 100)
                {
                    precio = value;
                }
                else precio = 0;
            }
        }

    }
}
