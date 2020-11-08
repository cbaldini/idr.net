using System;

namespace InfraestructuraDeRedes
{
	abstract class Cable:Recurso
	{
		int _intMetros;

		public int Metros {
			get {
				return _intMetros;
			}
			set { _intMetros = value; }
		}

		public abstract override string ToString();
	}
}

