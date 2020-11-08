using System;

namespace InfraestructuraDeRedes
{
	public class Router:Dispositivo, IEquatable<Router>, ITipoRecurso
	{
		public Router() {}

		public bool Equals(Router unrouter) {
			return (this.Modelo == unrouter.Modelo);
		}

		public string EstablecerTipo()
		{
			return "Router";
		}

		public string MostrarDatos()
		{
			return EstablecerTipo() + " " + Funcion + " marca " + Marca + ", modelo " + Modelo + " con " + CantidadBocas + " bocas. IP de gestión: " + IPbyte1 + "." + IPbyte2 + "." + IPbyte3 + "." + IPbyte4 + ". Precio en pesos: $" + PrecioPesos + ". Con IVA: $"+ PrecioIVA;
		}

		public override string ToString()
		{
			return EstablecerTipo()+ " " +Marca+", modelo "+Modelo;
		}
	}
}
