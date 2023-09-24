namespace Ejercicio3
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("3- Se creara un programa que mediante funciones, nos ayude a desglosar un importe introducido por consola, en el numero mínimo posible de billetes y monedas.");
			Console.WriteLine("Desglose de Importe");
			Console.WriteLine("-------------------");

			Console.WriteLine("Ingrese el importe: ");
			double importe = Convert.ToDouble(Console.ReadLine());

			DesglosarImporte(importe);

			Console.ReadLine();
		}

		static void DesglosarImporte(double importe)
		{
			int[] denominaciones = { 200, 100, 50, 20, 10, 5, 2, 1 };
			int[] cantidadDenominaciones = new int[denominaciones.Length];

			for (int i = 0; i < denominaciones.Length; i++)
			{
				cantidadDenominaciones[i] = (int)(importe / denominaciones[i]);
				importe %= denominaciones[i];
			}

			for (int i = 0; i < denominaciones.Length; i++)
			{
				if (cantidadDenominaciones[i] > 0)
				{
					Console.WriteLine($"Billete/Moneda de {cantidadDenominaciones[i]}:{denominaciones[i]} ");
				}
			}
		}
	}
}
