using System;
namespace Prueba
{
    public static class Conversiones
    {
        public static string Dec2Bin(this int n)
        {
            string s = string.Empty;
            while (n != 0)
            {
                s = (n % 2 == 0 ? "0" : "1") + s;
                n /= 2;
            }
            return s;
        }
        public static int Bin2Dec(this string s)
        {
            int r = 0;
            int y = s.Length - 1;
            foreach (char c in s)// for para operar sobre cada caracter de la cadena
            {
                r += (int)(c == '1' ? (int)Math.Pow(2, y) : 0);
                r--;
            }
            return r;
        }
    }
}