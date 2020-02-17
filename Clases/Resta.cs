namespace Proyecto_Calculadora
{
    public class Resta
    {
        public int Num3 { get; set; }
        public int Num4 { get; set; }

        private int _resultado;
        public int Resultado
        {
            get { return _resultado; }

            set
            {
                if (Num3 >= Num4)
                {
                    _resultado = Num3 - Num4;
                }
                else if (Num4 <= Num3)
                {
                    _resultado = Num4 - Num3;
                }
            }            
        }
    }
}
