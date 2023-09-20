using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            b = a % 2;
            if(b == 0)
            Console.WriteLine("es par");
            else 
            Console.WriteLine("es impar");
        }
    }
}

// Hacer un programa para ingresar un número y mostrar por pantalla un cartel
// aclaratorio si el mismo es PAR o IMPAR.
// Nota: leé sobre el operador “Resto”. En el próximo video lo explicaremos!