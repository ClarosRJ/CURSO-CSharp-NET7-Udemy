using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("2- Crear una calculadora , usando funciones de suma, resta, multiplicación y división.");
			/*
			  *Se creara un menú por consola, de la siguiente forma:

			 1- Suma

			 2- Resta

			 3- Multiplicación

			 4- División

			Seleccione la opción:

			dependiendo de la selección, se pedirán 2 números, y usando las funciones creadas, devolverá el resultado por consola */
			Console.WriteLine("Ingrese que operacion desea realizar: ");
			Console.WriteLine("1.- Suma ");
			Console.WriteLine("2.- Resta ");
			Console.WriteLine("3.- Multiplicacion ");
			Console.WriteLine("4.- Division ");
			int op = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ingrese el primer numero: ");
			double num1 = Convert.ToInt32(Console.ReadLine());
			Console.Write("Ingrese el segundo numero: ");
			double num2 = Convert.ToInt32(Console.ReadLine());
			double res = 0;
			switch (op)
			{
				case 1:
					res = Suma(num1, num2);
					Console.WriteLine("La suma de los dos numero ingresados es: " + res);
					break;
				case 2:
					res = Resta(num1, num2);
					Console.WriteLine("La Resta de los dos numero ingresados es: " + res);
					break;
				case 3:
					res = Multiplicar(num1, num2);
					Console.WriteLine("La multiplicacion de los dos numero ingresados es: " + res);
					break;
				case 4:
					res = Dividir(num1, num2);
					Console.WriteLine("La division de los dos numero ingresados es: " + res);
					break;
				default:
					break;
			}
			Console.ReadLine();
		}
		public static double Suma(double num1, double num2)
		{
			return num1 + num2;
		}
		public static double Resta(double num1, double num2)
		{
			return num1 - num2;
		}
		public static double Multiplicar(double num1, double num2)
		{
			return num1 * num2;
		}
		public static double Dividir(double num1, double num2)
		{
			return num1 / num2;
		}
	}
}
