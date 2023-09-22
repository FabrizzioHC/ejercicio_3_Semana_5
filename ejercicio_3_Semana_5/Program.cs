using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_3_Semana_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingresa el número de nota:");
            int n = int.Parse(Console.ReadLine());
            float sumadenotas = 0f;

            // for para bucle

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"ingresa la nota {i}:");
                float nota = float.Parse(Console.ReadLine());
                sumadenotas += nota;
            }

            float promedio = sumadenotas / n;
            Console.WriteLine($"el promedio es: {promedio}");
            Console.ReadKey();
        }
    }
}
