using System;

namespace Ejercicio_valdepeña
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            String s;
            Console.WriteLine("Ingresa una palabra");
            s= (Console.ReadLine());
         
            Console.WriteLine("Al revez es:   "+ Reversa(s));
            Console.WriteLine("En idioma efe: "+ Efe(s));
            Console.WriteLine("Tu texto original era: {0}", s);
        }
        //voltear la palabra
        static String Reversa(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        //idioma efe
        static String Efe (string s)
        {
            s = s.Replace("o", "ofo").Replace("a", "afa").Replace("e", "efe").Replace("i", "ifi").Replace("u", "ufu").Replace("O", "Ofo").Replace("A", "Afa").Replace("E", "Efe").Replace("I", "Ifi").Replace("U", "Ufu");
            return s;
        }


    }
}
    