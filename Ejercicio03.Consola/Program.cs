namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado[] arrayCuadrados = new Cuadrado[5];
            for (int i = 0; i < arrayCuadrados.Length; i++)
            {
                Console.Write("Ingrese el valor del lado:");
                arrayCuadrados[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Array completo.");
            Console.Clear();
            foreach ( var item in arrayCuadrados )
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}