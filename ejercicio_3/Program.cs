using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float n;
            Console.WriteLine("Cuanto es el importe de venta?");
            n = float.Parse(Console.ReadLine());
            if(n > 5000)
                n = n * 0.82F;
            else if (n > 1000)
                n = n * 0.90F;
            Console.WriteLine("el valor de tu venta es de: " + n.ToString("0.00") + "$"); 
        }
    }
}
// Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:
// Si el importe es menor a ARS 1000, no hay descuento.
// Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
// Si el importe es ARS 5000 o más, aplica un descuento del 18%.
// Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.