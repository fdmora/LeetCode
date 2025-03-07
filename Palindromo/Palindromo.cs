//program.cs
//Palindromo es una frase que puede leerse indistintamente tanto de izquierda
//a derecha como viceversa. Eliminando puntuacion y espacios, claro está.
//Crear un función que permita identificar si una cadena de texto es un palindromo.
//Ejemplos a probar:
//Atar a la rata
//Di clases al Cid
//La ruta natural

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena1 = "Atar a la rata";
            string cadena2 = "Di clases al Cid";
            string cadena3 = "La ruta natural";
            string cadena4 = "El Principito";

            Console.WriteLine(Palindromo(cadena1));
            Console.WriteLine(Palindromo(cadena2));
            Console.WriteLine(Palindromo(cadena3));
            Console.WriteLine(Palindromo(cadena4));

            Console.ReadLine();

        }

        static string Palindromo(string cadena)
        {
            string resultado = "";
            cadena = cadena.ToLower().Replace(" ", "");

            string cadena1 = "";
            string cadena2 = "";



            for (int i = 0; i < cadena.Length; i++)
            {
                cadena1 += cadena[i];
            }

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                cadena2 += cadena[i];
            }

            Console.WriteLine(cadena1);
            Console.WriteLine(cadena2);

            if (cadena1 == cadena2)
                resultado = cadena + " " + "Es un Palindromo";
            else
                resultado = resultado = cadena + " " + "No Es un Palindromo";
            return resultado;
        }

    }
}
