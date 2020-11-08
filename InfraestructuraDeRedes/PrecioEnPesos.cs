using System;

namespace InfraestructuraDeRedes
{
	public class PrecioEnPesos : IPrecio
	{
		double r;
		public void calculaprecio(double a)
		{
			r = a * 40;
		}

		public double resultado()
		{
			return r;

		}
	}
}