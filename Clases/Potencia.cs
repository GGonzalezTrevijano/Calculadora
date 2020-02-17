using System;

namespace Proyecto_Calculadora
{
    public class Potencia
    {
        public int Num9 { get; set; }
        public int Num10 { get; set; }

        public double _operacion;

        public double Operacion
        {
            get { return _operacion; }

            set
            {
                _operacion = Math.Pow(Num9, Num10);
            }
        }
    }
}
