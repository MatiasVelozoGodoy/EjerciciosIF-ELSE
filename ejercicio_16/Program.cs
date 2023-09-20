using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            a = a % 5;

            if(a == 0)
                Console.WriteLine("es multiplo de 5");
            else
                Console.WriteLine("no es multiplo de 5");
        }
    }
}

// Hacer un programa que solicite el ingreso de un número y que luego emita un
// cartel por pantalla aclarando si el mismo es múltiplo de 5.