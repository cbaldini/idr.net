using System;

namespace InfraestructuraDeRedes
{
	class CableDeFibraOptica:Cable, ITipoRecurso, IEquatable<CableDeFibraOptica>
	{

		public string EstablecerTipo()
		{
			return "Cable de fibra óptica";
		}

		int _intPelos;
		string _strModo;

		public int Pelos {
			get { return _intPelos; }
			set { _intPelos = value; }
		}
		public string Modo {
			get { return _strModo; }
			set { _strModo = value; }
		}

		public string MostrarDatos()
		{
			return EstablecerTipo()+" "+Marca+" modelo "+Modelo+" modo "+Modo+" con "+Pelos+" pelos. Precio en pesos: $"+PrecioPesos+". Con IVA: $"+PrecioIVA;
		}

		public override string ToString()
		{
			return EstablecerTipo() +" "+ Marca + ", modelo " + Modelo;
		}

		public bool Equals(CableDeFibraOptica otrafibra)
		{
			return (this.Modelo == otrafibra.Modelo);
		}
	}
}