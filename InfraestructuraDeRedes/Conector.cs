using System;

namespace InfraestructuraDeRedes
{
	public abstract class Conector:Recurso
	{
		int _intCantidad;

		public int Cantidad {
			get { return _intCantidad; }
			set { _intCantidad = value; }
		}
		public abstract override string ToString();
	}
}