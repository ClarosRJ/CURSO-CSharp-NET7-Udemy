using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio1
{
	class Program
	{
		/*Ejercicios Metodos y Funciones*/
		public static void Main(string[] args)
		{
			Console.WriteLine("1- Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.");
			Console.WriteLine("Introduce a que moneda desea cambiar");
			Console.WriteLine("1.- dolares: ");
			Console.WriteLine("2.- euros: ");
			int moneda = Convert.ToInt32(Console.ReadLine());
			Tipocabio(moneda);
			void Tipocabio(int moneda)
			{
				switch (moneda)
				{
					case 1:
						Console.WriteLine("Introduzca cuantos euros va a cambiar");
						double cantidad = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine("Introduzca a cuanto esta el $: ");
						double cambiodia = Convert.ToDouble(Console.ReadLine());
						double cambio = 0;
						cambio = cantidad * cambiodia;
						Math.Round(cambio, 2);
						Console.WriteLine("su cambio es: " + cambio + " dolares");
						break;
					case 2:
						Console.WriteLine("Introduzca cuantos dolares va a cambiar");
						cantidad = Convert.ToDouble(Console.ReadLine());
						Console.WriteLine("Introduzca a cuanto esta el Euro: ");
						cambiodia = Convert.ToDouble(Console.ReadLine());
						cambio = cantidad / cambiodia;
						Math.Round(cambio, 2);
						Console.WriteLine("su cambio es: " + cambio + " euros");
						break;
					default:
						break;
				}
			}

			Console.ReadLine();
		}
		
	}
}
