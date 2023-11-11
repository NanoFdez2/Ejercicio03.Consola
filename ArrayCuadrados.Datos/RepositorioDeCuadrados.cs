using ArrayCuadrados.Entidades;

namespace ArrayCuadrados.Datos
{
    public class RepositorioDeCuadrados
    {
        private readonly string _archivo = Environment.CurrentDirectory + "\\Cuadrados.txt";
        private readonly string _archivoCopia = Environment.CurrentDirectory + "\\Cuadrados.bak";
        private List<Cuadrado> listaCuadrados;

        

        public RepositorioDeCuadrados()
        {
            listaCuadrados = new List<Cuadrado>();
            LeerDatos();
        }
        public List<Cuadrado> GetLista()
        {
            return listaCuadrados;
        }
        private void LeerDatos()
        {
        if (File.Exists(_archivo))
            {
                var lector = new StreamReader(_archivo);
                while (!lector.EndOfStream)
                {
                string lineaLeida = lector.ReadLine();
                Cuadrado cuadrado = ConstruirCuadrado(lineaLeida);
                listaCuadrados.Add(cuadrado);
                }
            lector.Close(); 
            }
       

        }
        public void Editar (int ladoAnterior, Cuadrado cuadradoEditar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while (!lector.EndOfStream)
                    {
                        string lineaLeida=lector.ReadLine();
                        Cuadrado cuadrado = ConstruirCuadrado(lineaLeida);
                        if (ladoAnterior != cuadrado.GetLado())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                        else
                        {
                            lineaLeida = ConstruirLinea(cuadradoEditar);
                            escritor.WriteLine(lineaLeida );
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
        }
        private Cuadrado ConstruirCuadrado(string? lineaLeida)
        {
           var campos= lineaLeida.Split('|');
           int lado = int.Parse(campos[0]);
            TipodeBorde borde = (TipodeBorde)int.Parse(campos[0]);
            ColorRelleno color =(ColorRelleno) int.Parse(campos[0]);
            Cuadrado c = new Cuadrado(lado, borde, color);
            return c;

        }

        public void Agregar(Cuadrado cuadrado)
        {
            using (var escritor = new StreamWriter(_archivo, true))
            {
                string lineaEscribir = ConstruirLinea(cuadrado);
                escritor.WriteLine(lineaEscribir);
                escritor.Close();
            }

            
            listaCuadrados.Add(cuadrado);
        }

        private string ConstruirLinea(Cuadrado cuadrado)
        {
            return $"{cuadrado.GetLado()}";
        }

        public int GetCantidad(int? valorFiltro=null)
        {
            if (valorFiltro != null)
            {
                return listaCuadrados.Count(c => c.GetLado() >= valorFiltro);
            }
            return listaCuadrados.Count;
        }
        public void Borrar(Cuadrado cuadradoBorrar)
        {
            using (var lector = new StreamReader(_archivo))
            {
                using (var escritor = new StreamWriter(_archivoCopia))
                {
                    while(!lector.EndOfStream)
                    {
                        string lineaLeida = lector.ReadLine();
                        Cuadrado cuadradoLeido= ConstruirCuadrado(lineaLeida);
                        if (cuadradoBorrar.GetLado()!= cuadradoLeido.GetLado())
                        {
                            escritor.WriteLine(lineaLeida);
                        }
                    }
                }
            }
            File.Delete(_archivo);
            File.Move(_archivoCopia, _archivo);
            listaCuadrados.Remove(cuadradoBorrar);
        }

        public List<Cuadrado> Filtrar(int intValor)
        {
            return listaCuadrados.Where(c=>c.GetLado()>=intValor).ToList();
        }
    }
}