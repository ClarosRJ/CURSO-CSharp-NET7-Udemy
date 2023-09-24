using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio6
{
	class Program
	{
		/*
		 * Ejercicios Metodos y Funciones

	6- Crea un programa que este preguntando números por consola, hasta que se pulse el numero 0. una vez pulsado el 0 se mostrara la siguiente información:

	numero mas alto, numero mas bajo, la diferencia entre el mayor y el menor, cantidad de números introducidos

	Usa métodos y funciones y el bucle While para controlar que se introduce el numero 0.*/

		public static void Main(string[] args)
		{
			Console.WriteLine("6- Crea un programa que este preguntando números por consola, hasta que se pulse el numero 0. una vez pulsado el 0 se mostrara la siguiente información:" +
				"		numero mas alto, numero mas bajo, la diferencia entre el mayor y el menor, cantidad de números introducidos" +
				"		Usa métodos y funciones y el bucle While para controlar que se introduce el numero 0.");

			Console.WriteLine("Ingrese números (0 para finalizar):");
			Console.WriteLine("---------------------------------------------------------------");
			int numero;
			int contador = 0;
			int numeroMaximo = int.MinValue;
			int numeroMinimo = int.MaxValue;

			while (true)
			{
				numero = Convert.ToInt32(Console.ReadLine());

				if (numero == 0)
				{
					break;
				}

				contador++;
				numeroMaximo = ObtenerMaximo(numero, numeroMaximo);
				numeroMinimo = ObtenerMinimo(numero, numeroMinimo);
			}

			int diferencia = numeroMaximo - numeroMinimo;

			Console.WriteLine($"Número más alto: {numeroMaximo}");
			Console.WriteLine($"Número más bajo: {numeroMinimo}");
			Console.WriteLine($"Diferencia entre el mayor y el menor: {diferencia}");
			Console.WriteLine($"Cantidad de números introducidos: {contador}");

			Console.ReadLine();
		}

		static int ObtenerMaximo(int numero, int maximoActual)
		{
			return Math.Max(numero, maximoActual);
		}

		static int ObtenerMinimo(int numero, int minimoActual)
		{
			return Math.Min(numero, minimoActual);
		}
	}
}
