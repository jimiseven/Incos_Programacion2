﻿using System;
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
            int numero = 192;
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
            int saltos = 256/((int)Math.Pow(2, bits));

        string clase;

        if (numero >= 0 && numero <= 127)
        {
            clase = "Clase A";
        }
        else if (numero >= 128 && numero <= 191)
        {
            clase = "Clase B";
        }
        else if (numero >= 192 && numero <= 256)
        {
            clase = "Clase C";
        }
        else
        {
            clase = "Fuera de rango";
        }

        int masc = 0;
            if(clase == "Clase A"){
                masc = 8 + bits;
            }
            else if (clase == "Clase B")
            {
                masc = 16 + bits;
            }
            else if (clase == "Clase C")
            {
                masc = 24 + bits;
            }


            //imprecion de variables 
            Console.WriteLine("El número :" + numero + "pertenece a la clase :" + clase);
            Console.WriteLine("bits " + bits);
            Console.WriteLine("inds " + indS);
            Console.WriteLine("subredes " + subRedes);
            Console.WriteLine("masc " + masc);
            Console.WriteLine("clase " + clase);
            Console.WriteLine("saltos " + saltos);

            //parte para calcular las direcciones por grupos ()
            int dir = 0;
            int broad = (dir + saltos-1);
            int usableIni = dir+1;
            int usableEnd = broad -1;
            int ndir = 1;
            Console.WriteLine("Grupo de direcciones : " + ndir);
            Console.WriteLine("dir :" + dir);
            Console.WriteLine("broad :" + broad);
            Console.WriteLine("usableIni :" + usableIni);
            Console.WriteLine("usableEnd :" + usableEnd);
            ndir++;


            for (int ind = 1; ind < subRedes; ind++ )
            {
                dir = dir + saltos;
                broad = (dir + saltos - 1);
                usableIni = dir + 1;
                usableEnd = broad - 1;
                Console.WriteLine("Grupo de direcciones : " + ndir);
                Console.WriteLine("dir " + dir);
                Console.WriteLine("broad :" + broad);
                Console.WriteLine("usableIni :" + usableIni);
                Console.WriteLine("usableEnd :" + usableEnd);
                ndir++;
                
            }

        
        }
    }
}
