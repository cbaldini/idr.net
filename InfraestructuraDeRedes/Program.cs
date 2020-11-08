using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructuraDeRedes
{
	class Program
	{
		static void Main(string[] args)
		{
			int opcion;
			//Console.WriteLine("Seleccione el modo de ejecutar la aplicación: 1-Consola 2-GUI");
			try
			{
				//opcion = int.Parse(Console.ReadLine());
				opcion = 1;
				switch (opcion)
				{
				case 1:
					int menu;
					int ipaverificar;

					Router router = new Router();
					DispositivoWireless wireless = new DispositivoWireless();
					Switch unswitch = new Switch();
					CableEthernet cableether = new CableEthernet();
					CableDeFibraOptica fibra = new CableDeFibraOptica();
					FichaRJ45 rj45 = new FichaRJ45();
					ModuloSFP sfp = new ModuloSFP();


					List<object> lstRecursos = new List<object>();
					do
					{
						Console.Clear();
						Console.WriteLine("¿Qué dispositivo quiere ingresar? \n\n1-Router \n2-Dispositivo Wireless \n3-Switch \n4-Cable ethernet \n5-Cable de fibra óptica \n6-Ficha RJ45 \n7-Módulo SFP \n8-Mostrar lista \n9-Reiniciar \n0-Cerrar aplicación");
						menu = int.Parse(Console.ReadLine());
						if (menu > 9 || menu < 0)
						{
							Console.WriteLine("Ingrese una opción válida.");
							Console.Read();
						}
						//////////////////////////ROUTER///////////////////////////
						if (menu == 1)
						{

							PrecioEnPesos routerenpesos = new PrecioEnPesos();
							PrecioConIVA routerconiva = new PrecioConIVA();

							Console.Clear();
							Console.WriteLine("Ingrese las características del router.");
							Console.WriteLine("Función: ");
							router.Funcion = Console.ReadLine();
							Console.WriteLine("Marca: ");
							router.Marca = Console.ReadLine();
							Console.WriteLine("Modelo: ");
							router.Modelo = Console.ReadLine();
							Console.WriteLine("Cantidad de bocas: ");
							router.CantidadBocas = int.Parse(Console.ReadLine());

							Console.WriteLine("Ingrese la IP de gestión (presione ENTER al completar cada octeto): ");
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());
								if (router.VerificarIP(ipaverificar) == true)
								{
									router.IPbyte1 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (router.VerificarIP(ipaverificar) == false);
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());
								if (router.VerificarIP(ipaverificar) == true)
								{
									router.IPbyte2 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (router.VerificarIP(ipaverificar) == false);
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());
								if (router.VerificarIP(ipaverificar) == true)
								{
									router.IPbyte3 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (router.VerificarIP(ipaverificar) == false);
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());

								if (router.VerificarIP(ipaverificar) == true)
								{
									router.IPbyte4 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (router.VerificarIP(ipaverificar) == false);
							Console.WriteLine("Ingrese el precio en dólares: ");
							router.PrecioDolares = int.Parse(Console.ReadLine());

							routerenpesos.calculaprecio(router.PrecioDolares);
							router.PrecioPesos = routerenpesos.resultado();
							routerconiva.calculaprecio(router.PrecioPesos);
							router.PrecioIVA = routerconiva.resultado();
							bool repetido = false;

							foreach (object item in lstRecursos)
							{

								if (item is Router)
								{
									if (router.Equals((Router)item))
									{
										MensajeXRepetido();
										repetido = true;

									}

								}
							}
							if (repetido == false)
							{
								lstRecursos.Add(router);
								Console.WriteLine("Dispositivo agregado.");
								Console.ReadLine();
							}

						}


						//////////////////////////WIRELESS///////////////////////////
						if (menu == 2)
						{

							PrecioEnPesos wirelessenpesos = new PrecioEnPesos();
							PrecioConIVA wirelessconiva = new PrecioConIVA();

							Console.Clear();
							Console.WriteLine("Ingrese las características del router wireless:");
							Console.WriteLine("Función: ");
							wireless.Funcion = Console.ReadLine();
							Console.WriteLine("Marca: ");
							wireless.Marca = Console.ReadLine();
							Console.WriteLine("Modelo: ");
							wireless.Modelo = Console.ReadLine();
							Console.WriteLine("Cantidad de bocas: ");
							wireless.CantidadBocas = int.Parse(Console.ReadLine());
							Console.WriteLine("Ingrese el tipo de antena. 1-Omnidireccional 2-Grillada 3-Parabolica 4-Yagui 5-Panel");
							int tipo;
							tipo = int.Parse(Console.ReadLine());
							switch (tipo)
							{
							case 1:
								wireless.TipoAntena = "omnidireccional";
								break;
							case 2:
								wireless.TipoAntena = "grillada";
								break;
							case 3:
								wireless.TipoAntena = "parabolica";
								break;
							case 4:
								wireless.TipoAntena = "yagui";
								break;
							case 5:
								wireless.TipoAntena = "panel";
								break;
							default:
								Console.WriteLine("Ingreso inválido. Escriba una de las opciones del menú.");
								break;
							}


							Console.WriteLine("Ingrese los dbi de la antena");
							wireless.Dbi = int.Parse(Console.ReadLine());
							Console.WriteLine("Ingrese la potencia del equipo: ");
							wireless.Potencia = int.Parse(Console.ReadLine());
							Console.WriteLine("Ingrese la IP de gestión (presione ENTER al completar cada octeto): ");
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());
								if (wireless.VerificarIP(ipaverificar) == true)
								{
									wireless.IPbyte1 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (wireless.VerificarIP(ipaverificar) == false);
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());
								if (wireless.VerificarIP(ipaverificar) == true)
								{
									wireless.IPbyte2 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (wireless.VerificarIP(ipaverificar) == false);
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());
								if (wireless.VerificarIP(ipaverificar) == true)
								{
									wireless.IPbyte3 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (wireless.VerificarIP(ipaverificar) == false);
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());

								if (wireless.VerificarIP(ipaverificar) == true)
								{
									wireless.IPbyte4 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (wireless.VerificarIP(ipaverificar) == false);

							Console.WriteLine("Ingrese el precio en dólares: ");
							wireless.PrecioDolares = int.Parse(Console.ReadLine());

							wirelessenpesos.calculaprecio(wireless.PrecioDolares);
							wireless.PrecioPesos = wirelessenpesos.resultado();
							wirelessconiva.calculaprecio(wireless.PrecioPesos);
							wireless.PrecioIVA = wirelessconiva.resultado();
							bool repetido = false;

							foreach (object item in lstRecursos)
							{
								if (item is DispositivoWireless)
								{
									if (wireless.Equals((DispositivoWireless)item))
									{
										MensajeXRepetido();
										repetido = true;

									}

								}
							}
							if (repetido == false)
							{
								lstRecursos.Add(wireless);
								Console.WriteLine("Dispositivo agregado.");
								Console.ReadLine();
							}
						}
						//////////////////////////SWITCH///////////////////////////
						if (menu == 3)
						{
							Console.Clear();

							PrecioEnPesos switchenpesos = new PrecioEnPesos();
							PrecioConIVA switchconiva = new PrecioConIVA();

							string gest;

							Console.WriteLine("Ingrese las características del switch.");
							Console.WriteLine("Marca: ");
							unswitch.Marca = Console.ReadLine();
							Console.WriteLine("Modelo: ");
							unswitch.Modelo = Console.ReadLine();
							Console.WriteLine("Cantidad de bocas: ");
							unswitch.CantidadBocas = int.Parse(Console.ReadLine());
							Console.WriteLine("¿Es gestionable? s/n: ");
							do
							{
								gest = Console.ReadLine().ToLower();
								if (gest != "s" && gest != "n")
								{
									Console.WriteLine("Presione S para Si o N para No");
								}
							} while (gest != "s" && gest != "n");
							if (gest == "s")
							{
								unswitch.Gestionable = "Es gestionable";
							}
							else if (gest == "n")
							{
								unswitch.Gestionable = "No es gestionable";
							}

							Console.WriteLine("Ingrese la IP (presione ENTER al completar cada octeto): ");
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());
								if (unswitch.VerificarIP(ipaverificar) == true)
								{
									unswitch.IPbyte1 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (unswitch.VerificarIP(ipaverificar) == false);
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());
								if (unswitch.VerificarIP(ipaverificar) == true)
								{
									unswitch.IPbyte2 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (unswitch.VerificarIP(ipaverificar) == false);
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());
								if (unswitch.VerificarIP(ipaverificar) == true)
								{
									unswitch.IPbyte3 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (unswitch.VerificarIP(ipaverificar) == false);
							do
							{
								ipaverificar = int.Parse(Console.ReadLine());

								if (unswitch.VerificarIP(ipaverificar) == true)
								{
									unswitch.IPbyte4 = ipaverificar;
								}
								else
								{
									MensajeErrorDeIP();
								}
							} while (unswitch.VerificarIP(ipaverificar) == false);

							Console.WriteLine("Ingrese el precio en dólares: ");
							unswitch.PrecioDolares = int.Parse(Console.ReadLine());

							switchenpesos.calculaprecio(unswitch.PrecioDolares);
							unswitch.PrecioPesos = switchenpesos.resultado();
							switchconiva.calculaprecio(unswitch.PrecioPesos);
							unswitch.PrecioIVA = switchconiva.resultado();
							bool repetido = false;

							foreach (object item in lstRecursos)
							{
								if (item is Switch)
								{
									if (unswitch.Equals((Switch)item))
									{
										MensajeXRepetido();
										repetido = true;

									}

								}
							}
							if (repetido == false)
							{
								lstRecursos.Add(unswitch);
								Console.WriteLine("Dispositivo agregado.");
								Console.ReadLine();
							}
						}
						//////////////////////////ETHERNET///////////////////////////
						if (menu == 4)
						{
							PrecioEnPesos etherenpesos = new PrecioEnPesos();
							PrecioConIVA precioetherconiva = new PrecioConIVA();
							Console.WriteLine("Marca: ");
							cableether.Marca = Console.ReadLine();
							Console.WriteLine("Modelo: ");
							cableether.Modelo = Console.ReadLine();
							Console.WriteLine("Ingrese el precio en dólares: ");
							cableether.PrecioDolares = double.Parse(Console.ReadLine());
							etherenpesos.calculaprecio(cableether.PrecioDolares);
							cableether.PrecioPesos = etherenpesos.resultado();
							precioetherconiva.calculaprecio(cableether.PrecioPesos);
							cableether.PrecioIVA = precioetherconiva.resultado();
							Console.WriteLine("Metros: ");
							cableether.Metros = int.Parse(Console.ReadLine());
							Console.WriteLine("¿Interior o exterior? 1-Interior 2-Exterior");
							int intoext;
							intoext = int.Parse(Console.ReadLine());
							switch (intoext)
							{
							case 1:
								cableether.InteriorOExterior = "interior";
								break;
							case 2:
								cableether.InteriorOExterior = "exterior";
								break;
							default:
								Console.WriteLine("Opción incorrecta. Ingrese '1' para 'Interior' o '2' para 'Exterior'.");
								break;
							}
							Console.WriteLine("¿Vaina simple o doble? 1-Simple 2-Doble:  ");
							int simpleodoble;
							simpleodoble = int.Parse(Console.ReadLine());
							switch (simpleodoble)
							{
							case 1:
								cableether.Vaina = "simple";
								break;
							case 2:
								cableether.Vaina = "doble";
								break;
							default:
								Console.WriteLine("Opción inválida. Ingrese '1' para 'Simple' o '2' para 'Doble'");
								break;
							}
							bool repetido = false;

							foreach (object item in lstRecursos)
							{
								if (item is CableEthernet)
								{
									if (cableether.Equals((CableEthernet)item))
									{
										MensajeXRepetido();
										repetido = true;

									}

								}
							}
							if (repetido == false)
							{
								lstRecursos.Add(cableether);
								Console.WriteLine("Dispositivo agregado.");
								Console.ReadLine();
							}
						}
						//////////////////////////FIBRA///////////////////////////
						if (menu == 5)
						{

							PrecioEnPesos preciofibraenpesos = new PrecioEnPesos();
							PrecioConIVA preciofibraconiva = new PrecioConIVA();
							Console.WriteLine("Marca: ");
							fibra.Marca = Console.ReadLine();
							Console.WriteLine("Modelo: ");
							fibra.Modelo = Console.ReadLine();
							Console.WriteLine("Pelos: ");
							fibra.Pelos = int.Parse(Console.ReadLine());
							Console.WriteLine("Ingrese el precio en dólares: ");
							fibra.PrecioDolares = double.Parse(Console.ReadLine());
							preciofibraenpesos.calculaprecio(fibra.PrecioDolares);
							fibra.PrecioPesos = preciofibraenpesos.resultado();
							preciofibraconiva.calculaprecio(fibra.PrecioPesos);
							fibra.PrecioIVA = preciofibraconiva.resultado();
							Console.WriteLine("¿Modo? 1-Monomodo 2-Multimodo: ");
							int fibramodo;
							fibramodo = int.Parse(Console.ReadLine());
							switch (fibramodo)
							{
							case 1:
								fibra.Modo = "monomodo";
								break;
							case 2:
								fibra.Modo = "multimodo";
								break;
							default:
								Console.WriteLine("Ingreso incorrecto. Escriba '1' para monomodo o '2' para 'multimodo'.");
								break;
							}
							Console.WriteLine("Metros: ");
							fibra.Metros = int.Parse(Console.ReadLine());
							bool repetido = false;

							foreach (object item in lstRecursos)
							{
								if (item is CableDeFibraOptica)
								{
									if (fibra.Equals((CableDeFibraOptica)item))
									{
										MensajeXRepetido();
										repetido = true;

									}

								}
							}
							if (repetido == false)
							{
								lstRecursos.Add(fibra);
								Console.WriteLine("Dispositivo agregado.");
								Console.ReadLine();
							}
						}
						//////////////////////////RJ45///////////////////////////
						if (menu == 6)
						{
							PrecioEnPesos preciorj45enpesos = new PrecioEnPesos();
							PrecioConIVA preciorj45coniva = new PrecioConIVA();
							Console.WriteLine("Marca: ");
							rj45.Marca = Console.ReadLine();
							Console.WriteLine("Modelo: ");
							rj45.Modelo = Console.ReadLine();
							Console.WriteLine("Ingrese el precio en dólares: ");
							rj45.PrecioDolares = double.Parse(Console.ReadLine());
							preciorj45enpesos.calculaprecio(rj45.PrecioDolares);
							rj45.PrecioPesos = preciorj45enpesos.resultado();
							preciorj45coniva.calculaprecio(rj45.PrecioPesos);
							rj45.PrecioIVA = preciorj45coniva.resultado();
							Console.WriteLine("¿Común o blindada? 1-Comun 2-Blindada: ");
							int comunoblindada;
							comunoblindada = int.Parse(Console.ReadLine());
							switch (comunoblindada) {
							case 1:
								rj45.ComunOBlindada = "común";
								break;
							case 2:
								rj45.ComunOBlindada = "blindada";
								break;
							}
							bool repetido = false;
							foreach (object item in lstRecursos)
							{
								if (item is FichaRJ45)
								{
									if (rj45.Equals((FichaRJ45)item))
									{
										MensajeXRepetido();
										repetido = true;

									}

								}
							}
							if (repetido == false)
							{
								lstRecursos.Add(rj45);
								Console.WriteLine("Dispositivo agregado.");
								Console.ReadLine();
							}
						}
						//////////////////////////SFP///////////////////////////
						if (menu == 7)
						{
							PrecioEnPesos preciosfpenpesos = new PrecioEnPesos();
							PrecioConIVA preciosfpconiva = new PrecioConIVA();
							Console.WriteLine("Marca: ");
							sfp.Marca = Console.ReadLine();
							Console.WriteLine("Modelo: ");
							sfp.Modelo = Console.ReadLine();
							Console.WriteLine("Ingrese el precio en dólares: ");
							sfp.PrecioDolares = double.Parse(Console.ReadLine());
							preciosfpenpesos.calculaprecio(sfp.PrecioDolares);
							sfp.PrecioPesos = preciosfpenpesos.resultado();
							preciosfpconiva.calculaprecio(sfp.PrecioPesos);
							sfp.PrecioIVA = preciosfpconiva.resultado();
							Console.WriteLine("KM soportados: ");
							sfp.KMSoportados = int.Parse(Console.ReadLine());
							Console.WriteLine("¿Modo? 1-Monomodo 2-Multimodo: ");
							int sfpmodo;
							sfpmodo = int.Parse(Console.ReadLine());
							switch (sfpmodo) {
							case 1:
								sfp.Modo = "monomodo";
								break;
							case 2:
								sfp.Modo = "multimodo";
								break;
							default:
								Console.WriteLine("Ingreso incorrecto. Escriba '1' para monomodo o '2' para 'multimodo'.");
								break;
							}
							Console.WriteLine("Cantidad: ");
							sfp.Cantidad = int.Parse(Console.ReadLine());
							bool repetido = false;

							foreach (object item in lstRecursos)
							{
								if (item is ModuloSFP)
								{
									if (sfp.Equals((ModuloSFP)item))
									{
										MensajeXRepetido();
										repetido = true;

									}

								}
							}
							if (repetido == false)
							{
								lstRecursos.Add(sfp);
								Console.WriteLine("Dispositivo agregado.");
								Console.ReadLine();
							}
						}
						if (menu == 8)
						{
							
							foreach (object item in lstRecursos)
							{
								Console.WriteLine("\n_____________________________________________________________________________");
								if (item is Router) {
									Console.WriteLine(router.MostrarDatos());
								}
								if (item is Switch)
								{
									Console.WriteLine(unswitch.MostrarDatos());
								}
								if (item is DispositivoWireless)
								{
									Console.WriteLine(wireless.MostrarDatos());
								}
								if (item is CableEthernet)
								{
									Console.WriteLine(cableether.MostrarDatos());
								}
								if (item is CableDeFibraOptica)
								{
									Console.WriteLine(fibra.MostrarDatos());
								}
								if (item is FichaRJ45)
								{
									Console.WriteLine(rj45.MostrarDatos());
								}
								if (item is ModuloSFP)
								{
									Console.WriteLine(sfp.MostrarDatos());
								}

							}
							Console.WriteLine("\nPresiona ENTER para volver al menú principal.");
							Console.ReadLine();

						}

						if (menu == 9)
						{
//							Application.Restart();
						}

					} while (menu != 0 && menu != 9);
					break;
				case 2:
//					frmInfraestructuraDeRedes frm = new frmInfraestructuraDeRedes();
//					Application.Run(frm);
					break;
				default:
					Console.WriteLine("Ingreso incorrecto. Presione ENTER para volver a empezar.");
					Console.ReadLine();
//					Application.Restart();
					break;
				}
			}

			catch (Exception excepcion)
			{
				Console.WriteLine(excepcion.Message);
				Console.Read();
//				Application.Restart();
			}

		}

		private static void MensajeErrorDeIP()
		{
			Console.WriteLine("IP no válida. Ingrese números del 0 al 255.");
		}

		private static void MensajeXRepetido()
		{
			Console.WriteLine("Este dispositivo fue ingresado previamente. Ingrese otro modelo.");
			Console.ReadLine();
		}
	}
}