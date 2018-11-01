using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binarios
{
    class Program
    {
        static void Main(string[] args)
        {
            const int BASE =2;
            int NUM =0;
            int AUX = 0;
            int dad = 0;
            int I = 0;
            int [] VEC = new int[21];
            string linea;
            Console.Write("Ingrese un Numero:");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            dad = 1;
            while ((NUM >= BASE))
            {
                AUX = NUM % BASE;
                VEC[dad] = AUX;
                dad = dad + 1;
                NUM = NUM / BASE;
            }
            VEC[dad] = NUM;
            // salida
            for (I = dad; I >= 1;I += -1);
            {
                Console.Write(VEC[I] + " ");
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }
    }
}
