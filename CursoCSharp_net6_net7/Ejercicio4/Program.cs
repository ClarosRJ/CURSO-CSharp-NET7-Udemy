namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("4- Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, una cifra numérica o una consonante (realizar obligatoriamente 3 funciones, \"EsNumero\", \"EsVocal\", \"EsConsonante\").");
			Console.WriteLine("Clasificación de Carácter");
			Console.WriteLine("---------------------------------------------------------------------------");
			char car;
			do
			{
				Console.WriteLine("Ingrese un carácter:");
				char caracter = Console.ReadKey().KeyChar;
				Console.WriteLine();

				if (EsNumero(caracter))
				{
					Console.WriteLine("Es una cifra numérica.");
				}
				else if (EsVocal(caracter))
				{
					Console.WriteLine("Es una vocal.");
				}
				else if (EsConsonante(caracter))
				{
					Console.WriteLine("Es una consonante.");
				}
				else
				{
					Console.WriteLine("No se reconoce el carácter ingresado.");
				}
				Console.Write("Presione 'S' para continuar y 'N' para salir ");
				car = Convert.ToChar(Console.ReadLine()!);
			} while (car != 'n' && car != 'N');
			Console.ReadLine();
		}

		static bool EsNumero(char caracter)
		{
			return char.IsDigit(caracter);
		}

		static bool EsVocal(char caracter)
		{
			char[] vocales = { 'a', 'e', 'i', 'o', 'u' };
			return Array.IndexOf(vocales, char.ToLower(caracter)) != -1;
		}

		static bool EsConsonante(char caracter)
		{
			return char.IsLetter(caracter) && !EsVocal(caracter);
		}
	}
}
