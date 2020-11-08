using System;

namespace InfraestructuraDeRedes
{
	class CableEthernet:Cable, IEquatable<CableEthernet>
	{

		public string EstablecerTipo()
		{
			return "Cable ethernet";
		}
		string _strVaina;
		string _strIntOExt;

		public string Vaina {
			get { return _strVaina;}
			set { _strVaina = value; }
		}

		public string InteriorOExterior{
			get { return _strIntOExt; }
			set { _strIntOExt = value; }
		}

		public string MostrarDatos()
		{
			return EstablecerTipo()+" "+Marca+" modelo "+Modelo+" de vaina "+Vaina+", "+InteriorOExterior+". Precio en pesos: $"+PrecioPesos+". Con IVA: $"+PrecioIVA;
		}

		public override string ToString()
		{
			return EstablecerTipo() + " " + Marca + ", modelo " + Modelo;
		}

		public bool Equals(CableEthernet otroether)
		{
			return (this.Modelo == otroether.Modelo);
		}
	}
}