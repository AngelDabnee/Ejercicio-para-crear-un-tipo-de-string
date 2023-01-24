using MiClaseString;
using System;

namespace ClaseString // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Creamos el nuevo objeto, para poder utilizar el método creado del tipo string. 
            NuevoString nuevoString = new NuevoString(" ");
            Console.WriteLine("Que palabra quieres escribir");
            nuevoString.Valor = Console.ReadLine();
            Console.WriteLine("El nuevo valor de tu cadena es " + nuevoString.Valor);
            Console.WriteLine("El total de caracteres de tu string es " + nuevoString.Medida);
            Console.ReadKey();
        }
    }
}