using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame otro numero");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("dame otro numero");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("dame otro numero");
            d = int.Parse(Console.ReadLine());

            if (a == b && b == c && c == d)
                Console.WriteLine("los numeros son todos iguales");
            else
                Console.WriteLine("los numero son diferentes");
        }
    }
}

// Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si
// son todos iguales entre sí, caso contrario, no emitir nada.