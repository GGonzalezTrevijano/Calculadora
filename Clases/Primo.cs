namespace Proyecto_Calculadora
{
    public class Primo
    {
        public int Num14 { get; set; }

        public string _prim;

        public string Prim
        {
            get { return _prim; }

            set
            {
                int resultado = Num14 % 2;
                if (resultado == 0)
                {
                    _prim = ("Este numero es Par");
                }
                else if (resultado != 0)
                {
                    _prim = ("Este numero es Primo");                
                }
            }
        }
    }
}
