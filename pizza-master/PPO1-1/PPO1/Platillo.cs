using System;

namespace PPO1
{
	public class Platillo
	{
		private Alimento [] alimentos=new Alimento[3];

		public Platillo(){
		}

		public Platillo (Alimento[]alimentos) {
			this.alimentos = alimentos;
		}
		public Alimento[] Alimentos {
			get{ return this.alimentos;}
			set{ alimentos = value;}

		}

		public override string ToString ()
		{
			return string.Format ("[Platillo: a={0}]", alimentos);
		}
		
		
	}
}
