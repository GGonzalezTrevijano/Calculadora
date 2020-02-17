using System;

namespace Proyecto_Calculadora
{
    public class Coseno
    {
        public double Num12 { get; set; }

        public double _cosen;

        public double Cosen
        {
            get { return _cosen; }

            set
            {
                _cosen = Math.Asin(Num12);
            }
        }
    }
}
