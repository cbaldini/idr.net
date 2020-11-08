using System;

namespace InfraestructuraDeRedes
{
	class FichaRJ45:Conector, ITipoRecurso, IEquatable<FichaRJ45>
	{
		string _strComunOBlindada;

		public string ComunOBlindada{
			get { return _strComunOBlindada; }
			set { _strComunOBlindada = value; }
		}

		public string EstablecerTipo()
		{
			return "Ficha RJ45";
		}

		public bool Equals(FichaRJ45 otrorj)
		{
			return (this.Modelo == otrorj.Modelo);
		}

		public string MostrarDatos()
		{
			return EstablecerTipo()+" "+Marca +", modelo "+Modelo+" "+ComunOBlindada+". Cantidad: "+Cantidad+" precio en pesos: $"+PrecioPesos+" con IVA: $"+PrecioIVA;
		}

		public override string ToString()
		{
			return EstablecerTipo() + " " + Marca + ", modelo " + Modelo;
		}
	}
}