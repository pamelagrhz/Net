using System;

namespace PPO1
{
	public class Alimento : Producto
	{
	    int calorias;
		public int Calorias {
			get {
				return this.calorias;
			}
			set {
				calorias = value;
			}
		}

		public Alimento (string name, double price,int cal)
		{
			this.Nombre = name;
			this.Precio = price;
			this.Calorias = cal;
		}
		public Alimento(){}
		public override string ToString ()
		{
			string s;
			s = base.ToString ();
			s+= string.Format ("[calorias={0}]", calorias);
			return s;
		}
	}
}

