using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjrecP.C
{
    class Program
    { static void Main(string[] args)
        {
            int N;
            Console.Write("\n \t Ingresar la cantidad de números a digitar:");
            N = int.Parse(Console.ReadLine());



            for (int i = 1; i < N; ++i)
            {
                Console.WriteLine("{0} al cuadrado es: {1}", i, Math.Pow(i, 2));
            } // Fin de la instrucción for
