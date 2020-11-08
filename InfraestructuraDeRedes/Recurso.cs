using System;

namespace InfraestructuraDeRedes
{
	public abstract class Recurso
	{
		private string _strMarca;
		private string _strModelo;
		double _dblPrecioDolares;
		double _dblPrecioPesos;
		double _dblPrecioIva;

		public Recurso() { }


		public string Marca
		{

			get
			{
				return _strMarca;
			}
			set
			{
				_strMarca = value;
			}
		}

		public string Modelo {
			get {
				return _strModelo;
			}
			set {
				_strModelo = value;
			}
		}

		public double PrecioDolares
		{
			get
			{
				return _dblPrecioDolares;
			}
			set
			{
				_dblPrecioDolares = value;
			}
		}

		public double PrecioPesos
		{
			get {
				return _dblPrecioPesos;
			}
			set {
				_dblPrecioPesos = value;
			}

		}

		public double PrecioIVA {
			get {
				return _dblPrecioIva;
			}
			set {
				_dblPrecioIva = value;
			}
		}


	}
}