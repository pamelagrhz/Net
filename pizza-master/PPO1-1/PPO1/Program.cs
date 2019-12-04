using System;
using System.Collections.Generic;

namespace PPO1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Bienvenido, Escoja los ingredientes de su platillo");
			Alimento[] pla = new Alimento[3];
			string n1, n2, n3;
			int c1, c2, c3;
			double p1, p2, p3;
			Console.Write ("Ingresa el nombre del alimento: ");
			n1 = Console.ReadLine ();
			Console.Write ("Ingresa las calorias: ");
			c1 = int.Parse(Console.ReadLine ());
			Console.Write ("Ingresa el precio ");
			p1 = double.Parse(Console.ReadLine ());
			Console.Write ("Ingresa el nombre del alimento: ");

			n2 = Console.ReadLine ();
			Console.Write ("Ingresa las calorias: ");
			c2 = int.Parse(Console.ReadLine ());
			Console.Write ("Ingresa el precio ");
			p2 = double.Parse(Console.ReadLine ());
			Console.Write ("Ingresa el nombre del alimento: ");
			n3 = Console.ReadLine ();
			Console.Write ("Ingresa las calorias: ");
			c3 = int.Parse(Console.ReadLine ());
			Console.Write ("Ingresa el precio ");
			p3 = double.Parse(Console.ReadLine ());

			pla [0] = new Alimento (n1, p1, c1);
			pla [1] = new Alimento (n2, p2, c2);
			pla [2] = new Alimento (n3, p3, c3);
			double total = 0;
			Platillo p = new Platillo (pla);
			for (int i = 0; i < p.Alimentos.Length; i++) {
				Console.WriteLine (p.Alimentos.GetValue (i).ToString());
				Alimento a = (Alimento)p.Alimentos.GetValue (i);
				total += a.Precio;
			}
			Console.WriteLine ("Precio total: {0}",total);
			Console.ReadKey ();
		}
	}
}
