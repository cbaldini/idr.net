using System;

namespace InfraestructuraDeRedes
{
	public class DispositivoWireless : Dispositivo, IEquatable<DispositivoWireless>, ITipoRecurso
	{
		private string _strBanda;
		private string _strTipoAntena;
		private int _intDbi;
		private int _intPotencia;

		public bool Equals(DispositivoWireless otrowireless) {
			return (this.Modelo == otrowireless.Modelo);
		}

		public int Dbi
		{
			get
			{
				return _intDbi;
			}

			set
			{
				_intDbi = value;
			}
		}

		public string Banda
		{
			get
			{
				return _strBanda;
			}

			set
			{
				_strBanda = value;
			}
		}

		public string TipoAntena
		{
			get
			{
				return _strTipoAntena;
			}

			set
			{
				_strTipoAntena = value;
			}
		}

		public int Potencia {
			get {
				return _intPotencia;
			}
			set {
				_intPotencia = value;
			}
		}

		public string EstablecerTipo()
		{
			return "Dispositivo Wireless";
		}

		public string MostrarDatos()
		{
			return EstablecerTipo() + " " + Funcion + " marca " + Marca + ", modelo " + Modelo + " con " + CantidadBocas + " bocas. La antena es de tipo " + TipoAntena + " y tiene una ganancia de " + Dbi + " Dbi. El equipo tiene una potencia de " + Potencia + " watts. IP de gestión: " + IPbyte1 + "." + IPbyte2 + "." + IPbyte3 + "." + IPbyte4 +". Precio en pesos: $"+PrecioPesos+".Con IVA: $"+PrecioIVA;
		}

		public override string ToString()
		{
			return EstablecerTipo() + " " + Marca + ", modelo " + Modelo;
		}
	}
}
