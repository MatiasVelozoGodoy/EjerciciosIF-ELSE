using System;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("dame la primera nota");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("dame la segunda nota");
            b = int.Parse(Console.ReadLine());

            if(a >= 8 && b >= 8)
                Console.WriteLine("aprobacion directa");
            else if(a < 8 && a >= 6 && b < 8 && b >= 6)
                Console.WriteLine("rinde examen final");
            else if(a <= 6 && b <= 6)
                Console.WriteLine("debe recuperar");
        }
    }
}

// Hacer un programa que solicite el ingreso de las notas del primer parcial y del
// segundo parcial de una alumna de programación. El programa deberá analizar
// las notas y emitir la situación de la alumna según la siguiente escala:
// a. Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
// b. Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales (se
// aprueba con 6 o más), emitir “rinde examen final”.
// c. Si tiene menos de 6 en alguno de los dos parciales, emitir “debe
// recuperar”.