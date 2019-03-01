using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = new int[25];
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Ingresa el dato {0}", i + 1);
                arreglo[i] = int.Parse(Console.ReadLine());
            }

            int suma = 0;
            Console.Clear();
            foreach (var item in arreglo)
            {
                Console.WriteLine(item);
                suma += item;
            }
            Console.WriteLine("La suma es de: {0}",suma);
            Console.ReadLine();
        }
    }
}
