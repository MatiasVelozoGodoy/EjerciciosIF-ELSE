using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int procesador, ram, total = 0, disco = 0;
            Console.WriteLine("elija que procesador desea: i5(1), i7(2), i9(3)");
            procesador = int.Parse(Console.ReadLine());
            Console.WriteLine("ahora elija cuanta memoria desea: 8gb (1), 16gb (2), 32gb (3)");
            ram = int.Parse(Console.ReadLine());
            
            if(procesador == 1){
            switch(ram){
            case 1: 
                total = 800;
                break;
            case 2:
                total = 900;
                break;
            case 3:
                total = 1000;
                break;
            }
            }  else if(procesador == 2){
            switch(ram){
            case 1: 
                total = 900;
                break;
            case 2:
                total = 1000;
                break;
            case 3:
                total = 1400;
                break;
            }
            } else {
                switch(ram){
            case 1: 
                total = 1200;
                break;
            case 2:
                total = 1400;
                break;
            case 3:
                total = 2000;
                break;
            }
            }
        Console.WriteLine("Desea aumentar su disco a 1TB por 300 USD mas? elija 1 para extender o 0 para no hacerlo");
        disco = int.Parse(Console.ReadLine());
        switch (disco){
            case 0:
                total += 0;
                break;
            case 1:
                total += 300;
                break;
        }
            Console.WriteLine("El valor total de su compra es de: " + total + " USD");

        }
    }
}

// Una importante marca de computadoras permite elegir cierta configuración del equipo a comprar. 
// Para ello existe la siguiente escala de precios:
//                i5 (1)	i7 (2)	i9 (3)
// 8 RAM (1)	USD 800	USD 900	USD 1200
// 16 RAM (2)	USD 900	USD 1000	USD 1400
// 32 RAM (3)	USD 1000	USD 1400	USD 2000
// Además, el equipo viene con un disco que permite almacenar 500 GB de información 
// y que se puede ampliar a 1 TB si así lo desea, lo cual tiene un costo  adicional de USD 300. 
// Hacer un programa que solicite la opción de procesador, la opción de memoria  RAM, 
// y si extiende el disco o no (ingresa 1 para extender y 0 para no extender) 
// y calcule y emita por pantalla el monto de la máquina seleccionada.