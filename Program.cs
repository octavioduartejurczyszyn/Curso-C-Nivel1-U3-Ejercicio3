using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de video juegos otorga un descuento dependiendo del importe de la compra realizada según los siguientes valores:

            //Si el importe es menor a ARS 1000, no hay descuento.
            //Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
            //Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            //Hacer un programa para ingresar un importe de venta y luego muestre por pantalla el importe final con el descuento que corresponda.

            float IV;
            Console.WriteLine("Ingrese importe de venta");
            IV = float.Parse(Console.ReadLine());
            if(IV >= 1000){
                if(IV >= 5000)
                    IV = IV * 0.82F;
                else
                    IV = IV * 0.90F;
            }
            Console.WriteLine("Importe final: " + IV);

        }
    }
}
