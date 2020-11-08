using System;

namespace InfraestructuraDeRedes
{
	class ModuloSFP:Conector,IEquatable<ModuloSFP>,ITipoRecurso
	{

		public string EstablecerTipo()
		{
			return "Módulo SFP";
		}

		string _strModo;
		int _intKMSoportados;

		public string Modo {
			get { return _strModo; }
			set { _strModo = value; }
		}

		public int KMSoportados {
			get { return _intKMSoportados; }
			set { _intKMSoportados = value; }
		}

		public string MostrarDatos()
		{
			return EstablecerTipo()+" "+Marca+" modelo "+Modelo+" modo "+Modo+". Soporta "+KMSoportados+" kilómetros. Cantidad: "+Cantidad+". Precio en pesos: $"+PrecioPesos+". Con IVA: $"+PrecioIVA;
		}

		public override string ToString()
		{
			return EstablecerTipo() + " " + Marca + ", modelo " + Modelo;
		}

		public bool Equals(ModuloSFP otrosfp)
		{
			return (this.Modelo == otrosfp.Modelo);
		}
	}
}