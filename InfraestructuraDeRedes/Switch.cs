﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InfraestructuraDeRedes
{
	public class Switch : Dispositivo , IEquatable<Switch>, ITipoRecurso
	{
		public Switch() {}
		private string esgestionable;

		public string Gestionable {
			get { return esgestionable; }
			set { esgestionable = value; }
		}
		public bool Equals(Switch otroswitch)
		{
			return (this.Modelo == otroswitch.Modelo);
		}

		public string EstablecerTipo()
		{
			return "Switch";
		}

		public string MostrarDatos()
		{
			return EstablecerTipo() + " " + Marca + " " + Modelo + " con "+CantidadBocas + " bocas. "+esgestionable+ ". IP: " + IPbyte1 + "." + IPbyte2 + "." + IPbyte3 + "." + IPbyte4 +". Precio en pesos: $" + PrecioPesos + ". Con IVA: $"+PrecioIVA;
		}

		public override string ToString()
		{
			return EstablecerTipo() + " " + Marca + ", modelo " + Modelo;
		}
	}
}