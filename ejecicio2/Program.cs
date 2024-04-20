using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejecicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarolle un programa que escriba en pantalla los números del 1 al 10, usando "While"
            int numero = 1;

            Console.WriteLine("Números del 1 al 10: ");
            while (numero <= 10)
            {
                Console.WriteLine(numero);
                numero++;
            }
            Console.WriteLine("Presione Enter para finalizar...");
            Console.ReadLine();
        }
    }
}
