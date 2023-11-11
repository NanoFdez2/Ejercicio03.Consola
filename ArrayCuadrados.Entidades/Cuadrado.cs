namespace ArrayCuadrados.Entidades
{
    public class Cuadrado
    {
        private const int _cantidadLados = 4;
        private int _medidaLado;
        private TipodeBorde tipodeBorde;

        public TipodeBorde TipoDeBorde
        {
            get { return tipodeBorde; }
            set { tipodeBorde = value; }
        }

        private ColorRelleno colorRelleno;

        public ColorRelleno ColorRelleno
        {
            get { return colorRelleno; }
            set { colorRelleno = value; }
        }



        public Cuadrado(int medidaLado, TipodeBorde borde, ColorRelleno color)
        {
            _medidaLado = medidaLado;
            tipodeBorde = borde;
            colorRelleno = color;

        }

        public Cuadrado()
        {

        }

        public bool Validar()
        {
            return _medidaLado > 0;
        }
        public int GetLado() => _medidaLado;
        public void SetLado(int medida)
        {
            if (medida > 0)
            {
                _medidaLado = medida;
            }

        }
        public double GetPerimetro() => _cantidadLados * _medidaLado;
        public double GetSuperficie() => Math.Pow(_medidaLado, 2);

    }
}