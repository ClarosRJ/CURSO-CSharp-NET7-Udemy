using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
	public class Ejercicio1
	{
		static void Main(string[] args)
		{
			Console.WriteLine("1.- Crear 3 variables numéricas con el valor que tu quieras y en otra variable numérica guardar el valor de la suma de las 3 anteriores. Mostrar por consola.");

			int a = 0;
			int b = 1;
			int c = 2;

			int suma = a + b + c;
			Console.WriteLine(suma);
			Console.ReadLine();
			Ejercicio2 e = new Ejercicio2();
			e.Main();
		}

	}
	public class Ejercicio2
	{
		public void Main()
		{
			Console.WriteLine("2.- Pedir dos números al usuario por teclado y decir que número es el mayor.");

			int a = 0;
			Console.WriteLine("Ingrese un numero: ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ingrese otro numero: ");
			int b = Convert.ToInt32(Console.ReadLine());

			if (a > b)
			{
				Console.WriteLine("El primero numero ingresado es mayor que el segundo " + a + ">" + b);
			}
			else
			{
				Console.WriteLine("El segundo numero ingresado es mayor que el primero " + b + ">" + a);
			}
			Console.ReadLine();
			Ejercicio3 e = new Ejercicio3();
			e.Main();
		}
	}
	public class Ejercicio3
	{
		public void Main()
		{
			Console.WriteLine("3- Pedir el nombre de la semana al usuario y decirle si es fin de semana o no. En caso de error, indicarlo.");
			Console.WriteLine("Introduzca un dia de la semana: ");
			string dia = Console.ReadLine()!;
			switch (dia.ToLower())
			{
				case "lunes":
				case "martes":
				case "miercoles":
				case "jueves":
				case "viernes":
					Console.WriteLine("Es un dia de la semana");
					break;
				case "sabado":
				case "domingo":
					Console.WriteLine("Es un fin de semana");
					break;
				default:
					Console.WriteLine("El dia ingrasado no es correcto");
					break;
			}
			Console.ReadLine();
			Ejercicio4 e = new Ejercicio4();
			e.Main();
		}
	}
	public class Ejercicio4
	{
		public void Main()
		{
			Console.WriteLine("4- Pedir al usuario el precio de un producto (valor positivo) y la forma de pagar (efectivo o tarjeta) si la forma de pago es mediante tarjeta, pedir el numero de cuenta (inventado).");
			Console.WriteLine("Ingrese el precio del producto:");
			double precio = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Ingrese la forma de pago 'efectivo' o 'tarjeta' :");
			string pago = Console.ReadLine()!;
			if (pago == "tarjeta")
			{
				Console.WriteLine("Introduzca el numero de tarjeta: ");
				int tarjeta = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine(tarjeta);
			}
			Console.ReadLine();
			Ejercicio5 e = new Ejercicio5();
			e.Main();
		}
	}
	public class Ejercicio5
	{
		public void Main()
		{
			Console.WriteLine("5- Recorre los números del 1 al 100. Usa un bucle for.");
			Console.WriteLine("Ingrese un numero a recorrer en el for:");
			int num = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= num; i++)
			{
				Console.Write(i + ",");
			}
			Console.ReadLine();
			Ejercicio6 e = new Ejercicio6();
			e.Main();
		}
	}
	public class Ejercicio6
	{
		public void Main()
		{
			Console.WriteLine("+.- Recorre los números del 1 al 100. Usa un bucle while.");
			Console.WriteLine("Ingrese un numero para recorrer en el while");
			int num = Convert.ToInt32(Console.ReadLine());
			int i = 0;
			while (i < num)
			{
				i++;
				Console.Write(i + ",");

			}
			Console.ReadLine();
			Ejercicio7 e = new Ejercicio7();
			e.Main();
		}
	}
	public class Ejercicio7
	{
		public void Main()
		{
			Console.WriteLine("7- Recorre los números del 1 al 100. Muestra los números pares. Usar el tipo de bucle que quieras.");
			for (int i = 1; i <= 100; i += 2)
			{
				Console.WriteLine(i + ",");
			}
			Console.ReadLine();
			Ejercicio8 e = new Ejercicio8();
			e.Main();
		}
	}
	public class Ejercicio8
	{
		public void Main()
		{
			Console.WriteLine("8- Recorre los números del 1 al 100. Muestra los números pares o divisibles entre 3.");
			for (int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0 || i % 3 == 0)
				{
					Console.WriteLine(i + ",");
				}

			}
			Console.ReadLine();
			Ejercicio9 e = new Ejercicio9();
			e.Main();
		}
	}
	public class Ejercicio9
	{
		public void Main()
		{
			Console.WriteLine("9- Crea un array e inserta los números pares del 1 al 100 en ese array.");
			int[] array = new int[10];
			for (int i = 0; i < array.Length; i++)
			{
				Console.WriteLine("Ingresa un numero del 1 al 100:");
				int num = Convert.ToInt32(Console.ReadLine());
				if (num >= 1 && num <= 100)
				{
					if (num % 2 == 0)
					{
						array[i] = num;
					}
					else
					{
						array[i] = 0;
					}
				}
				else
				{
					Console.WriteLine("Ingrese un numero en el rango permitido");
					i--;
				}
			}
			foreach (int item in array)
			{
				if (item % 2 == 0)
				{
					Console.Write(item + ",");
				}
			}
			Console.ReadLine();
			Ejercicio10 e = new Ejercicio10();
			e.Main();
		}
	}
	public class Ejercicio10
	{
		public void Main()
		{
			Console.WriteLine("10- Pide 10 números por consola, muestra el resultado por consola de sumar los pares y restarle los impares.");

			int num = 0;
			int par = 0;
			int imp = 0;
			for (int i = 1; i <= 10; i++)
			{
				Console.Write(i + ".- Ingrese un numero:");
				num = Convert.ToInt32(Console.ReadLine());
				if (num % 2 == 0)
				{
					par = par + num;
				}
				else
				{
					imp = imp + num;
				}
			}
			Console.WriteLine("la suma de los numero pares es: " + par);
			Console.WriteLine("la suma de los numeros impares es: " + imp);
			Console.ReadLine();
			Ejercicio11 e = new Ejercicio11();
			e.Main();
		}
	}
	public class Ejercicio11
	{
		public void Main()
		{
			Console.WriteLine("11- Crea un programa, que pida un número del 1 al 7,  devuelva el día de la semana , teniendo en cuenta que el 1 es Lunes, hacer con un switch.");
			Console.WriteLine("ingrese un numero del 1 al 7");
			int num = Convert.ToInt32(Console.ReadLine());
			switch (num)
			{
				case 1:
					Console.WriteLine("lunes");
					break;
				case 2:
					Console.WriteLine("martes");
					break;
				case 3:
					Console.WriteLine("miercoles");
					break;
				case 4:
					Console.WriteLine("jueves");
					break;
				case 5:
					Console.WriteLine("viernes");
					break;
				case 6:
					Console.WriteLine("sabado");
					break;
				case 7:
					Console.WriteLine("domingo");
					break;
				default:
					Console.WriteLine("Ingrese un numero valido");
					break;
			}
			Console.ReadLine();
			Ejercicio12 e = new Ejercicio12();
			e.Main();
		}
	}
	public class Ejercicio12
	{
		public void Main()
		{
			Console.WriteLine("12- Crea un programa que pida por consola un numero del 1 al 1000 (validara que el numero introducido es correcto) y sume todos los números del 1 al numero introducido, mostrando por consola el numero de la suma y la media.");
			Console.WriteLine("Ingrese un numero del 1 al 1000: ");
			int num = Convert.ToInt32(Console.ReadLine());
			if (num >= 1 && num <= 1000)
			{
				int sum = 0;
				double media = 0;
				for (int i = 1; i <= num; i++)
				{
					sum = sum + i;
				}
				Console.WriteLine("La suma de los numeros del 1 al " + num + " es: " + sum);
				media = Convert.ToDouble(sum) / num;
				Console.WriteLine("La media de los numeros del numero introducido es " + media);
			}
			Console.ReadLine();
			Ejercicio13 e = new Ejercicio13();
			e.Main();
		}
	}
	public class Ejercicio13
	{

		public void Main()
		{
			//1,4 no primos
			//2, 3, 5 primos
			System.Console.WriteLine("13- Comprobar si un numero introducido por consola es primo");
			int can = 0;
			do
			{
				can++;
				int div = 0;
				Console.Write("Introduzca un numero: ");
				int num = Convert.ToInt32(Console.ReadLine());
				if (num <= 1)
				{
					Console.WriteLine("el numero " + num + " no es primo");
				}
				else if (num == 2)
				{
					Console.WriteLine("el numero  " + num + " es primo");
				}
				else
				{
					for (int i = 2; i < num; i++)
					{
						if (num % i == 0)
						{
							div++;
						}
					}
					if (div > 0)
					{
						Console.WriteLine("el numero " + num + " no es primo");
					}
					else
					{
						Console.WriteLine("el numero  " + num + " es primo");
					}
				}
			} while (can < 10);
			Console.ReadLine();
			Ejercicio14 e = new Ejercicio14();
			e.Main();
		}
	}
	public class Ejercicio14
	{
		public void Main()
		{
			System.Console.WriteLine("14- Crear un programa calcule cuantas cifras tiene un número entero positivo (pista: se puede hacer dividiendo varias veces entre 10).");
			int n, cifras;
			char car;
			do
			{
				Console.WriteLine("Introduce un número entero: ");
				n = Convert.ToInt32(Console.ReadLine());
				cifras = 0;
				while (n != 0)
				{
					n = n / 10;
					cifras++;
				}
				Console.WriteLine("El número tiene " + cifras + " cifras");
				Console.Write("Presione 'S' para continuar y 'N' para salir ");
				car = Convert.ToChar(Console.ReadLine()!);
			} while (car != 'n' && car != 'N');
			Console.ReadLine();
		}
	}
}
