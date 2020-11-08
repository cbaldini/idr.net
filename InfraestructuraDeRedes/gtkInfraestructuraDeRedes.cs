using System;

namespace InfraestructuraDeRedes
{
	public partial class gtkInfraestructuraDeRedes : Gtk.Window
	{
		public gtkInfraestructuraDeRedes () :
			base (Gtk.WindowType.Toplevel)
		{
			this.Build ();
		}
	}
}

