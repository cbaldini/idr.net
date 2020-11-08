using System;

namespace InfraestructuraDeRedes
{
	public class PrecioConIVA : IPrecio
	{
		double r;
		public void calculaprecio(double a)
		{
			r = a+(a*0.2);

		}

		public double resultado()
		{
			return r;

		}
	}
}