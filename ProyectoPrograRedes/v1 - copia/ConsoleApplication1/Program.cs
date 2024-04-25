using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int oct1 = 192;
            int oct2 = 168;
            int oct3 = 1;
            int subRedes = 11;
            int bits = 0;
            int indS = 0;
            do
            {
                // Calcular inds
                indS = (int)Math.Pow(2, bits) - 2;

                // Verificar si inds es igual o mayor a subRedes
                if (indS >= subRedes)
                {

                    break; // Salir del bucle
                }

                // Incrementar bits
                bits++;

            } while (true);
            int saltos = 256 / ((int)Math.Pow(2, bits));

            string clase;

            if (oct1 >= 0 && oct1 <= 127)
            {
                clase = "Clase A";
            }
            else if (oct1 >= 128 && oct1 <= 191)
            {
                clase = "Clase B";
            }
            else if (oct1 >= 192 && oct1 <= 256)
            {
                clase = "Clase C";
            }
            else
            {
                clase = "Fuera de rango";
            }

            int masc = 0;
            if (clase == "Clase A")
            {
                masc = 8 + bits;
            }
            else if (clase == "Clase B")
            {
                masc = 16 + bits;
            }
            else if (clase == "Clase C")
            {
                masc = 24 + bits;
                //parte para calcular las direcciones por grupos ()
                int dir = 0;
                int broad = (dir + saltos - 1);
                int usableIni = dir + 1;
                int usableEnd = broad - 1;
                int ndir = 1;
                Console.WriteLine("========================================");
                Console.WriteLine("Grupo de direcciones : " + ndir);
                Console.WriteLine("Direccion de iP:" + oct1 + "." + oct2 + "." + oct3 + "." + dir);
                Console.WriteLine("BroadCast :" + oct1 + "." + oct2 + "." + oct3 + "." + broad);
                Console.WriteLine("Primera ip USABLE :" + oct1 + "." + oct2 + "." + oct3 + "." + usableIni);
                Console.WriteLine("Ultima ip USABLE  :" + oct1 + "." + oct2 + "." + oct3 + "." + usableEnd);
                ndir++;
                Console.WriteLine("========================================");


                for (int ind = 1; ind < subRedes; ind++)
                {
                    dir = dir + saltos;
                    broad = (dir + saltos - 1);
                    usableIni = dir + 1;
                    usableEnd = broad - 1;
                    Console.WriteLine("Grupo de direcciones : " + ndir);
                    Console.WriteLine("Direccion de iP:" + oct1 + "." + oct2 + "." + oct3 + "." + dir);
                    Console.WriteLine("BroadCast :" + oct1 + "." + oct2 + "." + oct3 + "." + broad);
                    Console.WriteLine("Primera ip USABLE :" + oct1 + "." + oct2 + "." + oct3 + "." + usableIni);
                    Console.WriteLine("Ultima ip USABLE  :" + oct1 + "." + oct2 + "." + oct3 + "." + usableEnd);
                    ndir++;
                    Console.WriteLine("========================================");
                }
            }


            //imprecion de variables 
            Console.WriteLine("El número : " + oct1 + " pertenece a la clase : " + clase);
            Console.WriteLine("bits " + bits);
            Console.WriteLine("inds " + indS);
            Console.WriteLine("subredes " + subRedes);
            Console.WriteLine("masc " + masc);
            Console.WriteLine("clase " + clase);
            Console.WriteLine("saltos " + saltos);




        }
    }
}