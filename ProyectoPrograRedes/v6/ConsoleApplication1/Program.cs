using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace SubneteoRedes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de uso
            string ipRed = "192.168.1.0";
            int numSubredes = 4;

            CalcularSubredes(ipRed, numSubredes);
        }

        static void CalcularSubredes(string ipRed, int numSubredes)
        {
            // Convertir la IP de cadena a binario
            byte[] ipBinario = IPToBinario(ipRed);

            // Obtener la clase de IP
            int claseIP = ObtenerClaseIP(ipBinario[0]);

            // Calcular la máscara de subred
            byte[] mascaraSubred = CalcularMascaraSubred(claseIP, numSubredes);

            // Imprimir la información de cada subred
            for (int i = 0; i < numSubredes; i++)
            {
                byte[] ipSubred = ObtenerIPSubred(ipBinario, mascaraSubred, i);
                byte[] broadcast = ObtenerBroadcast(ipSubred, mascaraSubred);
                byte[] ipInicialUsable = ObtenerIPInicialUsable(ipSubred);
                byte[] ipFinalUsable = ObtenerIPFinalUsable(broadcast);

                Console.WriteLine("Subred {0}:", i + 1);
                Console.WriteLine(" - Dirección IP: " + BinarioToIP(ipSubred));
                Console.WriteLine(" - Broadcast: " + BinarioToIP(broadcast));
                Console.WriteLine(" - IP inicial usable: " + BinarioToIP(ipInicialUsable));
                Console.WriteLine(" - IP final usable: " + BinarioToIP(ipFinalUsable));
                Console.WriteLine(" - Máscara de subred: " + BinarioToIP(mascaraSubred));
                Console.WriteLine();
            }
        }

        // Convertir una IP de cadena a binario
        static byte[] IPToBinario(string ipRed)
        {
            string[] octetos = ipRed.Split('.');
            byte[] ipBinario = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                ipBinario[i] = Convert.ToByte(octetos[i]);
            }

            return ipBinario;
        }

        // Obtener la clase de IP
        static int ObtenerClaseIP(byte primerOcteto)
        {
            if (primerOcteto >= 0 && primerOcteto <= 127)
            {
                return 1; // Clase A
            }
            else if (primerOcteto >= 128 && primerOcteto <= 191)
            {
                return 2; // Clase B
            }
            else if (primerOcteto >= 192 && primerOcteto <= 223)
            {
                return 3; // Clase C
            }
            else
            {
                throw new Exception("IP no válida");
            }
        }

        // Calcular la máscara de subred
        static byte[] CalcularMascaraSubred(int claseIP, int numSubredes)
        {
            int mascaraBinario = 0;

            switch (claseIP)
            {
                case 1: // Clase A
                    mascaraBinario = 31 - (numSubredes - 1);
                    break;
                case 2: // Clase B
                    mascaraBinario = 15 - (numSubredes - 1);
                    break;
                case 3: // Clase C
                    mascaraBinario = 7 - (numSubredes - 1);
                    break;
                default:
                    throw new Exception("IP no válida");
            }

            byte[] mascaraSubred = new byte[4];

            for (int i = 0; i < mascaraBinario / 8; i++)
            {
                mascaraSubred[i] = 255;
            }

            int bitsRestantes = mascaraBinario % 8;
            mascaraSubred[mascaraBinario / 8] = (byte)(255 << (8 - bitsRestantes));

            for (int i = mascaraBinario / 8 + 1; i < 4; i++)
            {
                mascaraSubred[i] = 0;
            }
            // Obtener la IP de subred
static byte[] ObtenerIPSubred(byte[] ipBinario, byte[] mascaraSubred, int numSubred)
{
    byte[] ipSubred = new byte[4];

    for (int i = 0; i < 4; i++)
    {
        ipSubred[i] = (byte)(ipBinario[i] & mascaraSubred[i]);
    }

    // Agregar el número de subred al último octeto de la IP de subred
    ipSubred[3] += (byte)(numSubred << (8 - mascaraBinario % 8));

    return ipSubred;
}

// Obtener la dirección de broadcast
static byte[] ObtenerBroadcast(byte[] ipSubred, byte[] mascaraSubred)
{
    byte[] broadcast = new byte[4];

    for (int i = 0; i < 4; i++)
    {
        broadcast[i] = (byte)(ipSubred[i] | ~mascaraSubred[i]);
    }

    return broadcast;
}

// Obtener la IP inicial usable
static byte[] ObtenerIPInicialUsable(byte[] ipSubred)
{
    byte[] ipInicialUsable = new byte[4];

    for (int i = 0; i < 4; i++)
    {
        ipInicialUsable[i] = ipSubred[i];
    }

    // Incrementar el último octeto en 1
    ipInicialUsable[3] += 1;

    return ipInicialUsable;
}

// Obtener la IP final usable
static byte[] ObtenerIPFinalUsable(byte[] broadcast)
{
    byte[] ipFinalUsable = new byte[4];

    for (int i = 0; i < 4; i++)
    {
        ipFinalUsable[i] = broadcast[i];
    }

    // Decrementar el último octeto en 1
    ipFinalUsable[3] -= 1;

    return ipFinalUsable;
}

// Convertir una dirección IP binaria a cadena
static string BinarioToIP(byte[] ipBinario)
{
    string ip = string.Empty;

    for (int i = 0; i < 4; i++)
    {
        ip += ipBinario[i].ToString();

        if (i < 3)
        {
            ip += ".";
        }
    }

    return ip;
}
    }}




