using System;

namespace PPO1
{
	public abstract class Producto{
		public string nombre;
		public double precio;
		public Platillo platillo;

		public Platillo Platillo {
			get {
				return platillo;
			}
			set {
				platillo = value;
			}
		}

		public string Nombre {
			get {
				return this.nombre;
			}
			set {
				nombre = value;
			}
		}

		public double Precio {
			get {
				return this.precio;
			}
			set {
				precio = value;
			}
		}

		public override string ToString()
		{
			return string.Format ("[Producto: nombre={0}, precio={1}]", nombre, precio);
		}
		
		public Producto ()
		{
		}

	}
}

