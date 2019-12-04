using System;

namespace Chicharronera
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double a, b, c;
			Console.WriteLine ("Dame la letra a");
			a = Convert.ToDouble (Console.ReadLine ());
			Console.WriteLine ("Dame la letra b");
			b = Convert.ToDouble (Console.ReadLine ());
			Console.WriteLine ("Dame la letra c");
			c = Convert.ToDouble (Console.ReadLine ());

			double x1=(-b + Math.Sqrt((b*b)-(4*(a*c))))/(2*a);
			double x2=(-b - Math.Sqrt((b*b)-(4*(a*c))))/(2*a);
			// x2= Convert.ToInt32 (-b - Math.Sqrt((b*b)-(4*(a*c))))/(2*a);
			//double x2=(-b - Math.Sqrt((b*b)-(4*(a*c))))/(2*a);

			Console.WriteLine ("X1=:{0}",x1);
			Console.WriteLine ("X2=:{0}",x2);

			Console.ReadKey();

			
		}
	}
}
