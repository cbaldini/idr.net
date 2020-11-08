using System;

namespace InfraestructuraDeRedes
{
	public abstract class Dispositivo:Recurso
	{
		private string _strFuncionDispositivo;
		private int _intCantidadBocas;
		int _byte1, _byte2, _byte3, _byte4;

		public Dispositivo()
		{
		}

		public string Funcion
		{
			get
			{
				return _strFuncionDispositivo;
			}

			set
			{
				_strFuncionDispositivo = value;
			}
		}

		public int CantidadBocas
		{
			get
			{
				return _intCantidadBocas;
			}

			set
			{
				_intCantidadBocas = value;
			}
		}

		public int IPbyte1
		{
			get { return _byte1; }
			set { _byte1 = value; } 
		}
		public int IPbyte2
		{
			get { return _byte2; }
			set { _byte2 = value; }
		}

		public int IPbyte3
		{
			get { return _byte3; }
			set { _byte3 = value; }
		}

		public int IPbyte4
		{
			get { return _byte4; }
			set { _byte4 = value; }
		}

		public bool VerificarIP(int ip)
		{
			if (ip > 255 || ip < 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool Equals(Dispositivo otrodispositivo)
		{
			return (this.Modelo == otrodispositivo.Modelo);
		}

		public abstract override string ToString();

	}
}