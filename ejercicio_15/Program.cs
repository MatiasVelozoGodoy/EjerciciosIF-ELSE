using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame el segundo numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("dame el tercer numero");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("dame el cuarto numero");
            d = int.Parse(Console.ReadLine());

            if (a > b && b > c && c > d)
                Console.WriteLine("Esta de forma decreciente");
            
            Console.WriteLine("Fin");
        }
    }
}

// Hacer un programa para ingresar 4 números. 
// Luego analizar e informar por pantalla si los mismos se encuentran ordenados de forma decreciente .