using System;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, horas;
            Console.WriteLine("dame un numero");
            a = int.Parse(Console.ReadLine());
            horas = a / 60;
            if(a > 60)
            Console.WriteLine(horas + " horas");
            else 
            Console.WriteLine(a + " minutos");
            
        }
    }
}

// Hacer un programa para ingresar un valor que estará expresado en minutos. Si
// los minutos superan los 60, pasar el valor a horas, de lo contrario dejarlo en
// minutos. Mostrar el resultado en pantalla aclarando si se muestran minutos u
// horas.