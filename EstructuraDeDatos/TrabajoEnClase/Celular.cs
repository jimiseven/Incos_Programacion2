using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoEnClase
{
    class Celular
    {
        private int imei;
        private int numero;
        private string marca;
        private string modelo;
        private int costo;

        public Celular(int imei, int numero, string marca, string modelo, int costo)
        {
            this.imei = imei;
            this.numero = numero;
            this.marca = marca;
            this.modelo = modelo;
            this.costo = costo;
        }

        public void VisualizarCelular()
        {
            Console.WriteLine("LOS DATOS DEL CELULAR SON : ");
            Console.WriteLine("IMEI : " + imei);
            Console.WriteLine("NUMERO : " + numero);
            Console.WriteLine("MARCA: " + marca);
            Console.WriteLine("MODELO: " + modelo);
            Console.WriteLine("COSTO : " + costo);
        }

        public int Imei
        {
            get { return imei; }
            set { imei = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Costo
        {
            get { return costo; }
            set { costo = value; }
        }
    }
}
