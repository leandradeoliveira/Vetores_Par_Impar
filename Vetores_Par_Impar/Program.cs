using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vetores_Par_Impar
   

{
    
    internal class Program
    {
        static void Main()
        {
            int[] pares = new int[100];
            int[] impares = new int[100];
            int par = 0;
            int impar = -1;

            for (int i = 0; i < 100; i++)
            {
                par = par + 2;
                impar = impar + 2;
                pares[i] = par;
                impares[i] = impar;

            }
            // Impressão impares
            Console.WriteLine("Os 100 primeiros números ímpares são:");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(impares[i]);
            }
            // Impressão pares
            Console.WriteLine("Os 100 primeiros números pares são:");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(pares[i]);
            }

            Console.ReadKey();
        }


    }
}
