namespace Ejercicio5
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("5- Crear un programa usando funciones, que introduciendo un número por consola, pinte su tabla de multiplicar en la consola.");
			Console.WriteLine("Tabla de Multiplicar");
			Console.WriteLine("--------------------------------------------------------------------------------");

			Console.WriteLine("Ingrese un número: ");
			int numero = Convert.ToInt32(Console.ReadLine());
			TablaMultipicar(numero);
			Console.ReadLine();
		}
		public static void TablaMultipicar(int numero)
		{
			for (int i = 1; i <= 10; i++)
			{
				int resultado = numero * 1;
                Console.WriteLine(numero + " x " + i + " = "+ resultado);
				//Console.WriteLine($"{numero} x {i} = {resultado}");
			}
		}
	}
}
