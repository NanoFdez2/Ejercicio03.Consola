using ArrayCuadrados.Entidades;
namespace Ejercicio03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
            //Voy agregando los cuadrados manualmente y recorre el array
        {
            //Cuadrado[] arrayCuadrados = new Cuadrado[3];
            //for (int i = 0; i < arrayCuadrados.Length; i++)
            //{
            //    do
            //    {
            //        Console.Wriqte("Ingrese el valor del lado:");
            //        var lado = int.Parse(Console.ReadLine());
            //        Cuadrado cuadradoCreado = new Cuadrado(lado);
            //        if (cuadradoCreado.Validar())
            //        {
            //            arrayCuadrados[i] = cuadradoCreado;
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Cuadrado no válido.");
            //        }
            //    } while (true);
               

            //}
            //Console.WriteLine("Array completo.");
            //Console.Clear();
            //foreach (var item in arrayCuadrados)
            //{
            //    Console.WriteLine($"Cuadrado de lado: {item.GetLado()} - Superficie: {item.GetSuperficie()}.");

            //}
            //Console.WriteLine("Ingrese el nro. de cuadrado a modificar:");
            //var index=int.Parse(Console.ReadLine());
            //var cuadradoEditar=arrayCuadrados[index];
            //Console.WriteLine("Ingrese una nueva medida:");
            //var nuevaMedida=int.Parse(Console.ReadLine());
            //cuadradoEditar.SetLado(nuevaMedida);
            //Console.Clear();
            //foreach (var item in arrayCuadrados)
            //{
            //    Console.WriteLine($"Cuadrado de lado: {item.GetLado()} - Superficie: {item.GetSuperficie()}.");

            //}
            List<Cuadrado>lista=new List<Cuadrado>();
            
            //Agrego los cuadrados directamente
            lista.Add(new Cuadrado(2));
            lista.Add(new Cuadrado(11));
            lista.Add(new Cuadrado(9));
            Console.WriteLine(lista.Count);
            foreach (var item in lista)
            {
                Console.WriteLine(item.GetLado());
            }
            var CuadradoEdita = lista[2];
            CuadradoEdita.SetLado(13);
            foreach (var item in lista)
            {
                Console.WriteLine(item.GetLado());
            }
            lista.RemoveAt(1);
            Console.WriteLine(lista.Count);
        }
    }
}