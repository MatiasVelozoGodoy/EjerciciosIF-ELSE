using System;

namespace ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c = 0;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame otro numero");
            b = int.Parse(Console.ReadLine());
            if(b != 0){
                c = a / b;
                Console.WriteLine(c);
            }
            else 
                Console.WriteLine("no se puede dividir por cero");

        }
    }
}

// Hacer un programa para ingresar dos números. Si el segundo es distinto de
// cero, calcular la división del primero por el segundo y mostrar el resultado por
// pantalla; caso contrario, emitir un cartel aclarando que no se puede dividir por
// cero.